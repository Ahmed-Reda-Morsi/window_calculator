namespace window_calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.user_input = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Equal_button = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.sign_button = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.delete_element = new System.Windows.Forms.Button();
            this.clear_display = new System.Windows.Forms.Button();
            this.delete_all = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.user_input, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // user_input
            // 
            this.user_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_input.BackColor = System.Drawing.Color.DimGray;
            this.user_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_input.ForeColor = System.Drawing.Color.White;
            this.user_input.Location = new System.Drawing.Point(3, 3);
            this.user_input.Multiline = true;
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(576, 71);
            this.user_input.TabIndex = 0;
            this.user_input.Text = "0";
            this.user_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Silver;
            this.label.Location = new System.Drawing.Point(579, 77);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 41);
            this.label.TabIndex = 1;
            this.label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Equal_button, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.button19, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button18, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.sign_button, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button15, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button14, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button12, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button11, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.delete_element, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.clear_display, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.delete_all, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 121);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 471);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Equal_button
            // 
            this.Equal_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Equal_button.BackColor = System.Drawing.Color.Silver;
            this.Equal_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Equal_button.FlatAppearance.BorderSize = 5;
            this.Equal_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Equal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_button.Location = new System.Drawing.Point(435, 379);
            this.Equal_button.Name = "Equal_button";
            this.Equal_button.Size = new System.Drawing.Size(138, 89);
            this.Equal_button.TabIndex = 19;
            this.Equal_button.Text = "=";
            this.Equal_button.UseVisualStyleBackColor = false;
            this.Equal_button.Click += new System.EventHandler(this.Equal_button_Click);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.BackColor = System.Drawing.Color.Silver;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button19.FlatAppearance.BorderSize = 5;
            this.button19.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(291, 379);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(138, 89);
            this.button19.TabIndex = 18;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Num_Click);
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.BackColor = System.Drawing.Color.Silver;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button18.FlatAppearance.BorderSize = 5;
            this.button18.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(147, 379);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(138, 89);
            this.button18.TabIndex = 17;
            this.button18.Tag = "0";
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Num_Click);
            // 
            // sign_button
            // 
            this.sign_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sign_button.BackColor = System.Drawing.Color.Silver;
            this.sign_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sign_button.FlatAppearance.BorderSize = 5;
            this.sign_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.sign_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_button.Location = new System.Drawing.Point(3, 379);
            this.sign_button.Name = "sign_button";
            this.sign_button.Size = new System.Drawing.Size(138, 89);
            this.sign_button.TabIndex = 16;
            this.sign_button.Text = "+/-";
            this.sign_button.UseVisualStyleBackColor = false;
            this.sign_button.Click += new System.EventHandler(this.sign_button_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.BackColor = System.Drawing.Color.Silver;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button16.FlatAppearance.BorderSize = 5;
            this.button16.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(435, 285);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(138, 88);
            this.button16.TabIndex = 15;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.operation_Click);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.BackColor = System.Drawing.Color.Silver;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button15.FlatAppearance.BorderSize = 5;
            this.button15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(291, 285);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(138, 88);
            this.button15.TabIndex = 14;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Num_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button14.FlatAppearance.BorderSize = 5;
            this.button14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(147, 285);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(138, 88);
            this.button14.TabIndex = 13;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Num_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatAppearance.BorderSize = 5;
            this.button13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(3, 285);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(138, 88);
            this.button13.TabIndex = 12;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Num_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button12.FlatAppearance.BorderSize = 5;
            this.button12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(435, 191);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(138, 88);
            this.button12.TabIndex = 11;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.operation_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.BorderSize = 5;
            this.button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(291, 191);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(138, 88);
            this.button11.TabIndex = 10;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Num_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.BorderSize = 5;
            this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(147, 191);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(138, 88);
            this.button10.TabIndex = 9;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Num_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.BorderSize = 5;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(3, 191);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 88);
            this.button9.TabIndex = 8;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Num_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 5;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(435, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 88);
            this.button8.TabIndex = 7;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.operation_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 5;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(291, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 88);
            this.button7.TabIndex = 6;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Num_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 5;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(147, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 88);
            this.button6.TabIndex = 5;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Num_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 88);
            this.button5.TabIndex = 4;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Num_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(435, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 88);
            this.button4.TabIndex = 3;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.operation_Click);
            // 
            // delete_element
            // 
            this.delete_element.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_element.BackColor = System.Drawing.Color.Silver;
            this.delete_element.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delete_element.FlatAppearance.BorderSize = 5;
            this.delete_element.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.delete_element.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_element.Location = new System.Drawing.Point(291, 3);
            this.delete_element.Name = "delete_element";
            this.delete_element.Size = new System.Drawing.Size(138, 88);
            this.delete_element.TabIndex = 2;
            this.delete_element.Text = "DEL";
            this.delete_element.UseVisualStyleBackColor = false;
            this.delete_element.Click += new System.EventHandler(this.delete_element_Click);
            // 
            // clear_display
            // 
            this.clear_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_display.BackColor = System.Drawing.Color.Silver;
            this.clear_display.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clear_display.FlatAppearance.BorderSize = 5;
            this.clear_display.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clear_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_display.Location = new System.Drawing.Point(147, 3);
            this.clear_display.Name = "clear_display";
            this.clear_display.Size = new System.Drawing.Size(138, 88);
            this.clear_display.TabIndex = 1;
            this.clear_display.Text = "CE";
            this.clear_display.UseVisualStyleBackColor = false;
            this.clear_display.Click += new System.EventHandler(this.clear_display_Click);
            // 
            // delete_all
            // 
            this.delete_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_all.BackColor = System.Drawing.Color.Silver;
            this.delete_all.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delete_all.FlatAppearance.BorderSize = 5;
            this.delete_all.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.delete_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_all.Location = new System.Drawing.Point(3, 3);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(138, 88);
            this.delete_all.TabIndex = 0;
            this.delete_all.Text = "C";
            this.delete_all.UseVisualStyleBackColor = false;
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Equal_button;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button sign_button;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button delete_element;
        private System.Windows.Forms.Button clear_display;
        private System.Windows.Forms.Button delete_all;
    }
}

