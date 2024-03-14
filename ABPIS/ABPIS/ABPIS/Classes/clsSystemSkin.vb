Namespace ReservedCode

    Public Class windowsEvent

        Private Shared myBaseForm As Form
        Private Shared myPanel As Panel
        Public Shared Sub closeEvent(ByRef form As Form, ByRef pcClose As PictureBox, ByRef pnl As Panel)
            myBaseForm = form
            myPanel = pnl
            With pcClose
                AddHandler .MouseClick, AddressOf pc_Click
                AddHandler .MouseMove, AddressOf pc_MouseMove
                AddHandler .MouseLeave, AddressOf pc_MouseLeave
            End With
        End Sub

        Private Shared Sub pc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If TypeOf sender Is PictureBox Then
                CType(sender, PictureBox).Image = My.Resources._1436083425_Close_64
            End If
        End Sub

        Private Shared Sub pc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If TypeOf sender Is PictureBox Then
                CType(sender, PictureBox).Image = My.Resources._1436083425_Close_64_highlight2
            End If
        End Sub

        Private Shared Sub pc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            myBaseForm.Close()
        End Sub

    End Class

    Public Class Panels

        Private Shared sources_Form As Form
        'Mouse move event of the FORM
        Private Shared X_axis As Integer
        Private Shared y_axis As Integer
        Private Shared Move_Form As Boolean = False


        Public Shared Sub MoveForms(ByRef frm As Form, ByRef panels As Panel)
            sources_Form = frm
            With panels
                AddHandler .MouseDown, AddressOf MoveForm_MouseDown
                AddHandler .MouseMove, AddressOf MoveForm_MouseMove
                AddHandler .MouseUp, AddressOf MoveForm_MouseUp
            End With
        End Sub

        Private Shared Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Move_Form = False
        End Sub

        Private Shared Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Move_Form = True
                X_axis = e.X
                y_axis = e.Y
                'sender.Cursor = Cursors.SizeAll
            End If
            If CType(sources_Form, Form).Cursor = Cursors.SizeAll Then
                CType(sources_Form, Form).Cursor = Cursors.Default
            End If
        End Sub

        Private Shared Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If Move_Form Then
                Dim pt As New Point(e.X - X_axis, e.Y - y_axis)
                CType(sources_Form, Form).Left += pt.X
                CType(sources_Form, Form).Top += pt.Y
            End If
        End Sub

    End Class
End Namespace
