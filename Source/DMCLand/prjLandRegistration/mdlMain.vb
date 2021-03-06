'Khai bao su dung khong gian ten
Imports System.Configuration
Imports System.Data.SqlClient
'Dich
Imports System.Xml
Imports System.IO
Imports DMC.Land.User

Module mdlMain
    'Dich
    Public User As New clsUser
    '/Dich
    'Khai bao bien ket noi
    ' Public strConnection(bolKetNoiCSDL) As String
    'Khai bao bien kiem tra dang nhap
    Public blnGlobalDangNhap As Boolean = False
    'Khai bao bien Ma don vi hanh chinh hien thoi
    Public intGlobalMaDonViHanhChinh As Integer
    'Khai bao bien Ten don vi hanh chinh
    Public strGlobalTenDonViHanhChinh As String = ""
    'Khai báo Mã thửa đất hiện thời
    Public strGlbMaThuaDat As String = ""
    'Khai báo Mã hồ sơ cấp GCN hiện thời
    Public strGlbMaHoSoCapGCN As String = ""
    Public bolKetNoiCSDL As Boolean = True

    Sub main()
        Dim con As New SqlConnection()
    End Sub

    Public SqlConn As New SqlConnection
    Private document As New XmlDocument
    Public strGlobalServerName As String
    Public strGlobalUserID As String
    Public strGlobalUserPassword As String
    Public strGlobalDatabaseName As String
    Public strGlobalDatabaseNameQuan As String
    Dim strPathXML As String
    Public Function GiaiMa(ByVal strChuoiGiaiMa As String) As String


        Dim strKq As String = ""
        Dim arrMangXau() As Char = {}
        arrMangXau = strChuoiGiaiMa.ToCharArray()
        Dim arrMangMaHoa(arrMangXau.Length / 16 - 1) As String
        Dim j As Integer = 0
        For i As Integer = 0 To arrMangXau.Length - 1 Step 2
            arrMangMaHoa(j) = arrMangXau(i) & arrMangXau(i + 1)
            j = j + 1
            i = i + 16
        Next
        For k As Integer = 0 To arrMangMaHoa.Length - 2
            strKq = strKq & Chr(CInt("&H" & (arrMangMaHoa(k))))
        Next
        Return strKq.Substring(0, strKq.Length - 1)
    End Function

    Public Function GetConnection(ByVal bolKetNoi As Boolean) As String
        strPathXML = Application.StartupPath + "\config.xml"
        document.Load(strPathXML)
        Dim nodelist As XmlNodeList = document.SelectNodes("/Servers/Server[./TenKetNoi/text()]")
        If nodelist.Count > 0 Then
            strGlobalServerName = nodelist(0).ChildNodes(1).InnerText
            strGlobalDatabaseName = nodelist(0).ChildNodes(2).InnerText
            strGlobalDatabaseNameQuan = nodelist(0).ChildNodes(3).InnerText
            strGlobalUserID = nodelist(0).ChildNodes(4).InnerText
            strGlobalUserPassword = GiaiMa(nodelist(0).ChildNodes(5).InnerText)
        End If
        If bolKetNoi Then
            'strConnection = "Data Source=" & TenMayChu & ";Initial Catalog=" & DatabaseName & " ;User ID=" & UID & " ;PassWord=" & Upass & ""
            Return "SERVER=" & strGlobalServerName & ";DATABASE=" & strGlobalDatabaseName & " ;UID=" & strGlobalUserID & " ;PWD=" & strGlobalUserPassword & ""
        Else
            Return "SERVER=" & strGlobalServerName & ";DATABASE=" & strGlobalDatabaseNameQuan & " ;UID=" & strGlobalUserID & " ;PWD=" & strGlobalUserPassword & ""
        End If
        Return ""
    End Function


    ''' <summary>
    ''' Hàm chuyển chữ Tiếng Việt có dấu sang không dấu
    ''' </summary>
    ''' <param name="mystr"> nhập chuỗi cần chuyển</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function chuyensangkhongdau(ByVal mystr As String) As String
        Dim myChar() As String = {"aàáảãạăằắẳẵặâầấẩẫậ", "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬ", "ÒÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢ", "EÈÉẺẼẸÊỀẾỂỄỆ", "UÙÚỦŨỤƯỪỨỬỮỰ", "IÌÍỈĨỊ", "YỲÝỶỸỴ", "Đ", "oòóỏõọôồốổỗộơờớởỡợ", "eèéẻẽẹêềếểễệ", "uùúủũụưừứửữự", "iìíỉĩị", "yỳýỷỹỵ", "đ"}
        Dim myChar1() As String = {"a", "A", "O", "E", "U", "I", "Y", "D", "o", "e", "u", "i", "y", "d"}
        Dim str As String = mystr
        Dim strReturn As String = ""
        For i As Int32 = 0 To str.Length - 1
            Dim iStr As String = str.Substring(i, 1)
            Dim rStr As String = iStr

            For j As Int32 = 0 To myChar.Length - 1
                If myChar(j).IndexOf(iStr) >= 0 Then
                    rStr = myChar1(j)
                    Exit For
                End If
            Next
            strReturn += rStr
        Next
        Return strReturn
    End Function

    Public Function ThaoTacPhuongHienThoi(ByVal MaDVHD As String) As String
        Dim strKT As String = ""
        Try
            Dim dt As New DataTable
            'Khởi tạo giá trị cho biến nhận thông báo lỗi
            'Khởi tạo đối tượng thực thi cơ sở dữ liệu clsDatabase
            Dim Database As New DMC.Database.clsDatabase
            'Nếu kết nối cơ sở dữ liệu thành công
            Database.Connection = GetConnection(bolKetNoiCSDL)
            If Database.OpenConnection = True Then
                Dim paras() As String = {"@flag", "@MaDonViHanhChinh"}
                Dim values() As String = {0, MaDVHD}
                If (paras.Length <> values.Length) Then
                    Return ""
                End If
                Database.getValue(dt, "spKhoiTaoDuLieuPhuong", paras, values)
                Database.CloseConnection()
                If dt.Rows.Count > 0 Then
                    strKT = dt.Rows(0).Item("TenTablePhuong").ToString & "_"
                End If
            End If
        Catch ex As Exception
            MsgBox("Lỗi thực thi cơ sở dữ liệu", MsgBoxStyle.Information, "Lỗi thực thi cơ sở dữ liệu")
            Return ""
        End Try
        Return strKT
    End Function


    Public Sub TaoFileMaHoSoCapGCN(ByVal MaHoSoCapGCN As String)
        Dim strpathXML As String
        Dim document As New XmlDocument
        strpathXML = System.Windows.Forms.Application.StartupPath + "\MaHoSoCapGCN.xml"
        'Dim document As New XmlDocument

        If File.Exists(strpathXML) = False Then
            Dim strWrite As New StreamWriter(strpathXML)
            strWrite.WriteLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strWrite.WriteLine("<MaHoSo>")
            strWrite.WriteLine("</MaHoSo>")
            strWrite.Close()
        Else
            File.Delete(strpathXML)
            Dim strWrite As New StreamWriter(strpathXML)
            strWrite.WriteLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strWrite.WriteLine("<MaHoSo>")
            strWrite.WriteLine("</MaHoSo>")
            strWrite.Close()
        End If
        Try
            document.Load(strpathXML)
            Dim ItemNode As System.Xml.XmlNode
            ItemNode = document.CreateElement("MaHoSo")
            ' Thêm đặc tính.     
            Dim Attribute As XmlAttribute
            Attribute = document.CreateAttribute("id")
            Attribute.Value = document.ChildNodes(1).ChildNodes.Count + 1
            ItemNode.Attributes.Append(Attribute)
            ' Tạo và thêm các phần tử con cho nút này.       
            Dim strMaHoSo As System.Xml.XmlNode
            strMaHoSo = document.CreateElement("MaHoSoCapGCN")

            ItemNode.AppendChild(strMaHoSo)

            ' Thêm dữ liệu text.  
            strMaHoSo.AppendChild(document.CreateTextNode(MaHoSoCapGCN))
            document.DocumentElement.AppendChild(ItemNode)
            ' Lưu tài liệu.      
        Catch ex As Exception
            Dim strWrite As New StreamWriter(strpathXML)
            strWrite.WriteLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strWrite.WriteLine("<MaHoSo>")
            strWrite.WriteLine("</MaHoSo>")
            strWrite.Close()
        End Try
        document.Save(strpathXML)
    End Sub

    Public Sub KhoaControl(ByVal ctr As Control, ByVal trangthai As Boolean)
        For Each cmd1 As Object In ctr.Controls
            If ctr.Name.ToUpper <> "ctrlThongTinTraGCN".ToUpper Then
                If cmd1.Controls.Count > 0 Then
                    KhoaControl(cmd1, trangthai)
                Else
                    KhoaChucNang(cmd1, trangthai)
                End If
            End If
        Next
    End Sub
    Public Sub KhoaChucNang(ByVal ctr As Control, ByVal trangthai As Boolean)

        If ctr.GetType.ToString() = "System.Windows.Forms.Button" Then
            ctr.Enabled = trangthai
        End If

    End Sub

End Module
