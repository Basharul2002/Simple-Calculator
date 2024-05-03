using System.Drawing;
using System.Windows.Forms;

namespace Calculator
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
            this.one_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.point_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.multiplication_button = new System.Windows.Forms.Button();
            this.division_button = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.c_button = new System.Windows.Forms.Button();
            this.ce_button = new System.Windows.Forms.Button();
            this.output_tb = new System.Windows.Forms.TextBox();
            this.input_tb = new System.Windows.Forms.TextBox();
            this.error_warning_lvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // one_button
            // 
            this.one_button.BackColor = System.Drawing.Color.Coral;
            this.one_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one_button.FlatAppearance.BorderSize = 0;
            this.one_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.one_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.one_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.one_button.Location = new System.Drawing.Point(17, 199);
            this.one_button.Margin = new System.Windows.Forms.Padding(0);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(51, 42);
            this.one_button.TabIndex = 0;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = false;
            this.one_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // two_button
            // 
            this.two_button.BackColor = System.Drawing.Color.Coral;
            this.two_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two_button.FlatAppearance.BorderSize = 0;
            this.two_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.two_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.two_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.two_button.Location = new System.Drawing.Point(86, 199);
            this.two_button.Margin = new System.Windows.Forms.Padding(0);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(51, 42);
            this.two_button.TabIndex = 0;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = false;
            this.two_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // three_button
            // 
            this.three_button.BackColor = System.Drawing.Color.Coral;
            this.three_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three_button.FlatAppearance.BorderSize = 0;
            this.three_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.three_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.three_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.three_button.Location = new System.Drawing.Point(154, 199);
            this.three_button.Margin = new System.Windows.Forms.Padding(0);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(51, 42);
            this.three_button.TabIndex = 0;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = false;
            this.three_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // six_button
            // 
            this.six_button.BackColor = System.Drawing.Color.Coral;
            this.six_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six_button.FlatAppearance.BorderSize = 0;
            this.six_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.six_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.six_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.six_button.Location = new System.Drawing.Point(154, 146);
            this.six_button.Margin = new System.Windows.Forms.Padding(0);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(51, 42);
            this.six_button.TabIndex = 0;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = false;
            this.six_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // five_button
            // 
            this.five_button.BackColor = System.Drawing.Color.Coral;
            this.five_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five_button.FlatAppearance.BorderSize = 0;
            this.five_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.five_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.five_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.five_button.Location = new System.Drawing.Point(86, 146);
            this.five_button.Margin = new System.Windows.Forms.Padding(0);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(51, 42);
            this.five_button.TabIndex = 0;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = false;
            this.five_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // four_button
            // 
            this.four_button.BackColor = System.Drawing.Color.Coral;
            this.four_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four_button.FlatAppearance.BorderSize = 0;
            this.four_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.four_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.four_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.four_button.Location = new System.Drawing.Point(17, 146);
            this.four_button.Margin = new System.Windows.Forms.Padding(0);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(51, 42);
            this.four_button.TabIndex = 0;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = false;
            this.four_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // seven_button
            // 
            this.seven_button.BackColor = System.Drawing.Color.Coral;
            this.seven_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven_button.FlatAppearance.BorderSize = 0;
            this.seven_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.seven_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seven_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.seven_button.Location = new System.Drawing.Point(17, 92);
            this.seven_button.Margin = new System.Windows.Forms.Padding(0);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(51, 42);
            this.seven_button.TabIndex = 0;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = false;
            this.seven_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // eight_button
            // 
            this.eight_button.BackColor = System.Drawing.Color.Coral;
            this.eight_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight_button.FlatAppearance.BorderSize = 0;
            this.eight_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eight_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.eight_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.eight_button.Location = new System.Drawing.Point(86, 92);
            this.eight_button.Margin = new System.Windows.Forms.Padding(0);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(51, 42);
            this.eight_button.TabIndex = 0;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = false;
            this.eight_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // nine_button
            // 
            this.nine_button.BackColor = System.Drawing.Color.Coral;
            this.nine_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine_button.FlatAppearance.BorderSize = 0;
            this.nine_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nine_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nine_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.nine_button.Location = new System.Drawing.Point(154, 92);
            this.nine_button.Margin = new System.Windows.Forms.Padding(0);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(51, 42);
            this.nine_button.TabIndex = 0;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = false;
            this.nine_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // zero_button
            // 
            this.zero_button.BackColor = System.Drawing.Color.Coral;
            this.zero_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero_button.FlatAppearance.BorderSize = 0;
            this.zero_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zero_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.zero_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.zero_button.Location = new System.Drawing.Point(17, 253);
            this.zero_button.Margin = new System.Windows.Forms.Padding(0);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(123, 42);
            this.zero_button.TabIndex = 0;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = false;
            this.zero_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // point_button
            // 
            this.point_button.BackColor = System.Drawing.Color.Coral;
            this.point_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point_button.FlatAppearance.BorderSize = 0;
            this.point_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.point_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.point_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.point_button.Location = new System.Drawing.Point(154, 253);
            this.point_button.Margin = new System.Windows.Forms.Padding(0);
            this.point_button.Name = "point_button";
            this.point_button.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.point_button.Size = new System.Drawing.Size(51, 42);
            this.point_button.TabIndex = 0;
            this.point_button.Text = ".";
            this.point_button.UseVisualStyleBackColor = false;
            this.point_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // minus_button
            // 
            this.minus_button.BackColor = System.Drawing.Color.Coral;
            this.minus_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus_button.FlatAppearance.BorderSize = 0;
            this.minus_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minus_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minus_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.minus_button.Location = new System.Drawing.Point(223, 199);
            this.minus_button.Margin = new System.Windows.Forms.Padding(0);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(51, 42);
            this.minus_button.TabIndex = 0;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = false;
            this.minus_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.Color.Coral;
            this.plus_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_button.FlatAppearance.BorderSize = 0;
            this.plus_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.plus_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plus_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.plus_button.Location = new System.Drawing.Point(223, 253);
            this.plus_button.Margin = new System.Windows.Forms.Padding(0);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(51, 42);
            this.plus_button.TabIndex = 0;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // multiplication_button
            // 
            this.multiplication_button.BackColor = System.Drawing.Color.Coral;
            this.multiplication_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplication_button.FlatAppearance.BorderSize = 0;
            this.multiplication_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.multiplication_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.multiplication_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.multiplication_button.Location = new System.Drawing.Point(223, 146);
            this.multiplication_button.Margin = new System.Windows.Forms.Padding(0);
            this.multiplication_button.Name = "multiplication_button";
            this.multiplication_button.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.multiplication_button.Size = new System.Drawing.Size(51, 42);
            this.multiplication_button.TabIndex = 0;
            this.multiplication_button.Text = "*";
            this.multiplication_button.UseVisualStyleBackColor = false;
            this.multiplication_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // division_button
            // 
            this.division_button.BackColor = System.Drawing.Color.Coral;
            this.division_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.division_button.FlatAppearance.BorderSize = 0;
            this.division_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.division_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.division_button.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.division_button.Location = new System.Drawing.Point(223, 92);
            this.division_button.Margin = new System.Windows.Forms.Padding(0);
            this.division_button.Name = "division_button";
            this.division_button.Size = new System.Drawing.Size(51, 42);
            this.division_button.TabIndex = 0;
            this.division_button.Text = "/";
            this.division_button.UseVisualStyleBackColor = false;
            this.division_button.Click += new System.EventHandler(this.input_value_Click);
            // 
            // equal_button
            // 
            this.equal_button.BackColor = System.Drawing.Color.Coral;
            this.equal_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal_button.FlatAppearance.BorderSize = 0;
            this.equal_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.equal_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.equal_button.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.equal_button.Location = new System.Drawing.Point(291, 199);
            this.equal_button.Margin = new System.Windows.Forms.Padding(0);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(51, 95);
            this.equal_button.TabIndex = 0;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = false;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // c_button
            // 
            this.c_button.BackColor = System.Drawing.Color.LightCoral;
            this.c_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_button.FlatAppearance.BorderSize = 0;
            this.c_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.c_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.c_button.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.c_button.Location = new System.Drawing.Point(291, 147);
            this.c_button.Margin = new System.Windows.Forms.Padding(0);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(51, 42);
            this.c_button.TabIndex = 0;
            this.c_button.Text = "DEL";
            this.c_button.UseVisualStyleBackColor = false;
            this.c_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // ce_button
            // 
            this.ce_button.BackColor = System.Drawing.Color.LightCoral;
            this.ce_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ce_button.FlatAppearance.BorderSize = 0;
            this.ce_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ce_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ce_button.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.ce_button.Location = new System.Drawing.Point(291, 92);
            this.ce_button.Margin = new System.Windows.Forms.Padding(0);
            this.ce_button.Name = "ce_button";
            this.ce_button.Size = new System.Drawing.Size(51, 42);
            this.ce_button.TabIndex = 0;
            this.ce_button.Text = "AC";
            this.ce_button.UseVisualStyleBackColor = false;
            this.ce_button.Click += new System.EventHandler(this.ac_button_Click);
            // 
            // output_tb
            // 
            this.output_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_tb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.output_tb.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.output_tb.Location = new System.Drawing.Point(17, 24);
            this.output_tb.Multiline = true;
            this.output_tb.Name = "output_tb";
            this.output_tb.ReadOnly = true;
            this.output_tb.Size = new System.Drawing.Size(329, 65);
            this.output_tb.TabIndex = 1;
            this.output_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_tb
            // 
            this.input_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.input_tb.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.input_tb.Location = new System.Drawing.Point(20, 28);
            this.input_tb.Multiline = true;
            this.input_tb.Name = "input_tb";
            this.input_tb.ReadOnly = true;
            this.input_tb.Size = new System.Drawing.Size(323, 29);
            this.input_tb.TabIndex = 2;
            // 
            // error_warning_lvl
            // 
            this.error_warning_lvl.AutoSize = true;
            this.error_warning_lvl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.error_warning_lvl.Location = new System.Drawing.Point(21, 30);
            this.error_warning_lvl.Name = "error_warning_lvl";
            this.error_warning_lvl.Size = new System.Drawing.Size(134, 50);
            this.error_warning_lvl.TabIndex = 3;
            this.error_warning_lvl.Text = "Syntax Error \r\n[AC]   : Cancel";
            this.error_warning_lvl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 315);
            this.Controls.Add(this.error_warning_lvl);
            this.Controls.Add(this.input_tb);
            this.Controls.Add(this.output_tb);
            this.Controls.Add(this.ce_button);
            this.Controls.Add(this.division_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.c_button);
            this.Controls.Add(this.multiplication_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.point_button);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.one_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button point_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button multiplication_button;
        private System.Windows.Forms.Button division_button;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.Button c_button;
        private System.Windows.Forms.Button ce_button;
        private System.Windows.Forms.TextBox output_tb;
        private System.Windows.Forms.TextBox input_tb;
        private System.Windows.Forms.Label error_warning_lvl;
            
    }

}

