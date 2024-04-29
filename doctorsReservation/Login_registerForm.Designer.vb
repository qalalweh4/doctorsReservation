<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_registerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonGoToLogin = New System.Windows.Forms.Button()
        Me.ButtonGoToRegister = New System.Windows.Forms.Button()
        Me.Panel_Register1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email_Register = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Register = New System.Windows.Forms.Button()
        Me.Password_Register = New System.Windows.Forms.TextBox()
        Me.username_Register = New System.Windows.Forms.TextBox()
        Me.username_Login = New System.Windows.Forms.TextBox()
        Me.password_Login = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Login = New System.Windows.Forms.Panel()
        Me.Panel_Register1.SuspendLayout()
        Me.Panel_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonGoToLogin
        '
        Me.ButtonGoToLogin.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonGoToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonGoToLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoToLogin.Location = New System.Drawing.Point(12, 37)
        Me.ButtonGoToLogin.Name = "ButtonGoToLogin"
        Me.ButtonGoToLogin.Size = New System.Drawing.Size(195, 56)
        Me.ButtonGoToLogin.TabIndex = 0
        Me.ButtonGoToLogin.Text = "Login"
        Me.ButtonGoToLogin.UseVisualStyleBackColor = False
        '
        'ButtonGoToRegister
        '
        Me.ButtonGoToRegister.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonGoToRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonGoToRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoToRegister.Location = New System.Drawing.Point(277, 37)
        Me.ButtonGoToRegister.Name = "ButtonGoToRegister"
        Me.ButtonGoToRegister.Size = New System.Drawing.Size(195, 56)
        Me.ButtonGoToRegister.TabIndex = 1
        Me.ButtonGoToRegister.Text = "Register"
        Me.ButtonGoToRegister.UseVisualStyleBackColor = False
        '
        'Panel_Register1
        '
        Me.Panel_Register1.Controls.Add(Me.Label5)
        Me.Panel_Register1.Controls.Add(Me.email_Register)
        Me.Panel_Register1.Controls.Add(Me.Label3)
        Me.Panel_Register1.Controls.Add(Me.Label4)
        Me.Panel_Register1.Controls.Add(Me.Button_Register)
        Me.Panel_Register1.Controls.Add(Me.Password_Register)
        Me.Panel_Register1.Controls.Add(Me.username_Register)
        Me.Panel_Register1.Location = New System.Drawing.Point(22, 118)
        Me.Panel_Register1.Name = "Panel_Register1"
        Me.Panel_Register1.Size = New System.Drawing.Size(460, 312)
        Me.Panel_Register1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email:"
        '
        'email_Register
        '
        Me.email_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_Register.Location = New System.Drawing.Point(108, 98)
        Me.email_Register.Name = "email_Register"
        Me.email_Register.Size = New System.Drawing.Size(245, 29)
        Me.email_Register.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "username"
        '
        'Button_Register
        '
        Me.Button_Register.BackColor = System.Drawing.Color.DarkOrange
        Me.Button_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Register.Location = New System.Drawing.Point(105, 208)
        Me.Button_Register.Name = "Button_Register"
        Me.Button_Register.Size = New System.Drawing.Size(245, 56)
        Me.Button_Register.TabIndex = 2
        Me.Button_Register.Text = "Register"
        Me.Button_Register.UseVisualStyleBackColor = False
        '
        'Password_Register
        '
        Me.Password_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_Register.Location = New System.Drawing.Point(108, 146)
        Me.Password_Register.Name = "Password_Register"
        Me.Password_Register.Size = New System.Drawing.Size(245, 29)
        Me.Password_Register.TabIndex = 1
        '
        'username_Register
        '
        Me.username_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_Register.Location = New System.Drawing.Point(108, 44)
        Me.username_Register.Name = "username_Register"
        Me.username_Register.Size = New System.Drawing.Size(245, 29)
        Me.username_Register.TabIndex = 0
        '
        'username_Login
        '
        Me.username_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_Login.Location = New System.Drawing.Point(108, 44)
        Me.username_Login.Name = "username_Login"
        Me.username_Login.Size = New System.Drawing.Size(245, 29)
        Me.username_Login.TabIndex = 0
        '
        'password_Login
        '
        Me.password_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_Login.Location = New System.Drawing.Point(108, 89)
        Me.password_Login.Name = "password_Login"
        Me.password_Login.Size = New System.Drawing.Size(245, 29)
        Me.password_Login.TabIndex = 1
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(108, 146)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(245, 56)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "password"
        '
        'Panel_Login
        '
        Me.Panel_Login.Controls.Add(Me.Label2)
        Me.Panel_Login.Controls.Add(Me.Label1)
        Me.Panel_Login.Controls.Add(Me.LoginButton)
        Me.Panel_Login.Controls.Add(Me.password_Login)
        Me.Panel_Login.Controls.Add(Me.username_Login)
        Me.Panel_Login.Location = New System.Drawing.Point(22, 115)
        Me.Panel_Login.Name = "Panel_Login"
        Me.Panel_Login.Size = New System.Drawing.Size(460, 312)
        Me.Panel_Login.TabIndex = 2
        '
        'Login_registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(500, 506)
        Me.Controls.Add(Me.Panel_Register1)
        Me.Controls.Add(Me.Panel_Login)
        Me.Controls.Add(Me.ButtonGoToRegister)
        Me.Controls.Add(Me.ButtonGoToLogin)
        Me.Name = "Login_registerForm"
        Me.Text = "Login_registerForm"
        Me.Panel_Register1.ResumeLayout(False)
        Me.Panel_Register1.PerformLayout()
        Me.Panel_Login.ResumeLayout(False)
        Me.Panel_Login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonGoToLogin As Button
    Friend WithEvents ButtonGoToRegister As Button
    Friend WithEvents Panel_Register1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents email_Register As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_Register As Button
    Friend WithEvents Password_Register As TextBox
    Friend WithEvents username_Register As TextBox
    Friend WithEvents Panel_Login As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents password_Login As TextBox
    Friend WithEvents username_Login As TextBox
End Class
