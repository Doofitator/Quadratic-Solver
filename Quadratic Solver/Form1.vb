Public Class frm_quadraticSolver
    Private Sub btn_solve_Click(sender As Object, e As EventArgs) Handles btn_solve.Click
        Dim a = nud_a.Value
        Dim b = nud_b.Value
        Dim c = nud_c.Value

        Dim quadratic1 = ((0 - b) + Math.Sqrt((b ^ 2) - (4 * a * c))) / (2 * a)
        Dim quadratic2 = ((0 - b) - Math.Sqrt((b ^ 2) - (4 * a * c))) / (2 * a)

        lbl_x1.Text = quadratic1
        lbl_x2.Text = quadratic2
    End Sub
End Class
