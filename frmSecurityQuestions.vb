Imports Org.BouncyCastle.Asn1.X509

Public Class frmSecurityQuestions
    Private Sub frmSecurityQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assuming frmLogin is already defined and accessible
        frmLogin.TopLevel = False
        frmLogin.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmLogin.Dock = DockStyle.Fill
        Panel1.Controls.Clear() ' Replace YourPanelName with the actual name of your panel
        Panel1.Controls.Add(frmLogin)
        frmLogin.Show()
    End Sub

End Class