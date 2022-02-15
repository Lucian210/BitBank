namespace bank
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createCard = new Guna.UI2.WinForms.Guna2Button();
            this.Aceducation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Acincome = new Guna.UI2.WinForms.Guna2TextBox();
            this.Acocupation = new Guna.UI2.WinForms.Guna2TextBox();
            this.Acadress = new Guna.UI2.WinForms.Guna2TextBox();
            this.Acphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.Acname = new Guna.UI2.WinForms.Guna2TextBox();
            this.Acgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // createCard
            // 
            this.createCard.AutoRoundedCorners = true;
            this.createCard.BorderRadius = 21;
            this.createCard.CheckedState.Parent = this.createCard;
            this.createCard.CustomImages.Parent = this.createCard;
            this.createCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createCard.DisabledState.Parent = this.createCard;
            this.createCard.FillColor = System.Drawing.Color.Black;
            this.createCard.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.createCard.ForeColor = System.Drawing.Color.White;
            this.createCard.HoverState.Parent = this.createCard;
            this.createCard.Location = new System.Drawing.Point(85, 450);
            this.createCard.Name = "createCard";
            this.createCard.ShadowDecoration.Parent = this.createCard;
            this.createCard.Size = new System.Drawing.Size(229, 45);
            this.createCard.TabIndex = 0;
            this.createCard.Text = "Create Card";
            this.createCard.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Aceducation
            // 
            this.Aceducation.BackColor = System.Drawing.Color.Transparent;
            this.Aceducation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Aceducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Aceducation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Aceducation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Aceducation.FocusedState.Parent = this.Aceducation;
            this.Aceducation.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.Aceducation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Aceducation.HoverState.Parent = this.Aceducation;
            this.Aceducation.ItemHeight = 30;
            this.Aceducation.Items.AddRange(new object[] {
            "high school",
            "bachelor",
            "master"});
            this.Aceducation.ItemsAppearance.Parent = this.Aceducation;
            this.Aceducation.Location = new System.Drawing.Point(60, 325);
            this.Aceducation.Name = "Aceducation";
            this.Aceducation.ShadowDecoration.Parent = this.Aceducation;
            this.Aceducation.Size = new System.Drawing.Size(280, 36);
            this.Aceducation.StartIndex = 1;
            this.Aceducation.TabIndex = 33;
            // 
            // Acincome
            // 
            this.Acincome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Acincome.DefaultText = "";
            this.Acincome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Acincome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Acincome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acincome.DisabledState.Parent = this.Acincome;
            this.Acincome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acincome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acincome.FocusedState.Parent = this.Acincome;
            this.Acincome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.Acincome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acincome.HoverState.Parent = this.Acincome;
            this.Acincome.Location = new System.Drawing.Point(60, 225);
            this.Acincome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acincome.Name = "Acincome";
            this.Acincome.PasswordChar = '\0';
            this.Acincome.PlaceholderText = "Anual income";
            this.Acincome.SelectedText = "";
            this.Acincome.ShadowDecoration.Parent = this.Acincome;
            this.Acincome.Size = new System.Drawing.Size(280, 35);
            this.Acincome.TabIndex = 31;
            // 
            // Acocupation
            // 
            this.Acocupation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Acocupation.DefaultText = "";
            this.Acocupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Acocupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Acocupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acocupation.DisabledState.Parent = this.Acocupation;
            this.Acocupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acocupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acocupation.FocusedState.Parent = this.Acocupation;
            this.Acocupation.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.Acocupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acocupation.HoverState.Parent = this.Acocupation;
            this.Acocupation.Location = new System.Drawing.Point(60, 275);
            this.Acocupation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acocupation.Name = "Acocupation";
            this.Acocupation.PasswordChar = '\0';
            this.Acocupation.PlaceholderText = "Occupation";
            this.Acocupation.SelectedText = "";
            this.Acocupation.ShadowDecoration.Parent = this.Acocupation;
            this.Acocupation.Size = new System.Drawing.Size(280, 35);
            this.Acocupation.TabIndex = 29;
            // 
            // Acadress
            // 
            this.Acadress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Acadress.DefaultText = "";
            this.Acadress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Acadress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Acadress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acadress.DisabledState.Parent = this.Acadress;
            this.Acadress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acadress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acadress.FocusedState.Parent = this.Acadress;
            this.Acadress.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.Acadress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acadress.HoverState.Parent = this.Acadress;
            this.Acadress.Location = new System.Drawing.Point(59, 175);
            this.Acadress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acadress.Name = "Acadress";
            this.Acadress.PasswordChar = '\0';
            this.Acadress.PlaceholderText = "Adress";
            this.Acadress.SelectedText = "";
            this.Acadress.ShadowDecoration.Parent = this.Acadress;
            this.Acadress.Size = new System.Drawing.Size(280, 35);
            this.Acadress.TabIndex = 26;
            // 
            // Acphone
            // 
            this.Acphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Acphone.DefaultText = "";
            this.Acphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Acphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Acphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acphone.DisabledState.Parent = this.Acphone;
            this.Acphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acphone.FocusedState.Parent = this.Acphone;
            this.Acphone.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.Acphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acphone.HoverState.Parent = this.Acphone;
            this.Acphone.Location = new System.Drawing.Point(60, 125);
            this.Acphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acphone.Name = "Acphone";
            this.Acphone.PasswordChar = '\0';
            this.Acphone.PlaceholderText = "Phone";
            this.Acphone.SelectedText = "";
            this.Acphone.ShadowDecoration.Parent = this.Acphone;
            this.Acphone.Size = new System.Drawing.Size(280, 35);
            this.Acphone.TabIndex = 24;
            // 
            // Acname
            // 
            this.Acname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Acname.DefaultText = "";
            this.Acname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Acname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Acname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acname.DisabledState.Parent = this.Acname;
            this.Acname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Acname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acname.FocusedState.Parent = this.Acname;
            this.Acname.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.Acname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acname.HoverState.Parent = this.Acname;
            this.Acname.Location = new System.Drawing.Point(60, 75);
            this.Acname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acname.Name = "Acname";
            this.Acname.PasswordChar = '\0';
            this.Acname.PlaceholderText = "Name";
            this.Acname.SelectedText = "";
            this.Acname.ShadowDecoration.Parent = this.Acname;
            this.Acname.Size = new System.Drawing.Size(280, 35);
            this.Acname.TabIndex = 22;
            this.Acname.TextChanged += new System.EventHandler(this.Acname_TextChanged);
            // 
            // Acgender
            // 
            this.Acgender.BackColor = System.Drawing.Color.Transparent;
            this.Acgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Acgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Acgender.FocusedState.Parent = this.Acgender;
            this.Acgender.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.Acgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Acgender.HoverState.Parent = this.Acgender;
            this.Acgender.ItemHeight = 30;
            this.Acgender.Items.AddRange(new object[] {
            "male",
            "female",
            "giraffe"});
            this.Acgender.ItemsAppearance.Parent = this.Acgender;
            this.Acgender.Location = new System.Drawing.Point(60, 375);
            this.Acgender.Name = "Acgender";
            this.Acgender.ShadowDecoration.Parent = this.Acgender;
            this.Acgender.Size = new System.Drawing.Size(280, 36);
            this.Acgender.StartIndex = 1;
            this.Acgender.TabIndex = 21;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(59, 30);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(282, 21);
            this.guna2HtmlLabel8.TabIndex = 44;
            this.guna2HtmlLabel8.Text = "Let\'s create your virtual card!";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(365, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(30, 30);
            this.guna2Button2.TabIndex = 47;
            this.guna2Button2.Text = "x";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.Aceducation);
            this.Controls.Add(this.Acincome);
            this.Controls.Add(this.Acocupation);
            this.Controls.Add(this.Acadress);
            this.Controls.Add(this.Acphone);
            this.Controls.Add(this.Acname);
            this.Controls.Add(this.Acgender);
            this.Controls.Add(this.createCard);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button createCard;
        private Guna.UI2.WinForms.Guna2ComboBox Aceducation;
        private Guna.UI2.WinForms.Guna2TextBox Acincome;
        private Guna.UI2.WinForms.Guna2TextBox Acocupation;
        private Guna.UI2.WinForms.Guna2TextBox Acadress;
        private Guna.UI2.WinForms.Guna2TextBox Acphone;
        private Guna.UI2.WinForms.Guna2TextBox Acname;
        private Guna.UI2.WinForms.Guna2ComboBox Acgender;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}