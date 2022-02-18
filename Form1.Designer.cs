
namespace CalculadoraWinforms
{
    partial class frm_calculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_cero = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lbl_history = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_deleteAll);
            this.panel1.Controls.Add(this.btn_division);
            this.panel1.Controls.Add(this.btn_mult);
            this.panel1.Controls.Add(this.btn_substract);
            this.panel1.Controls.Add(this.btn_eight);
            this.panel1.Controls.Add(this.btn_nine);
            this.panel1.Controls.Add(this.btn_equal);
            this.panel1.Controls.Add(this.btn_sum);
            this.panel1.Controls.Add(this.btn_seven);
            this.panel1.Controls.Add(this.btn_four);
            this.panel1.Controls.Add(this.btn_five);
            this.panel1.Controls.Add(this.btn_six);
            this.panel1.Controls.Add(this.btn_one);
            this.panel1.Controls.Add(this.btn_two);
            this.panel1.Controls.Add(this.btn_three);
            this.panel1.Controls.Add(this.btn_punto);
            this.panel1.Controls.Add(this.btn_cero);
            this.panel1.Location = new System.Drawing.Point(10, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 245);
            this.panel1.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(81, 21);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(154, 37);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "del";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_deleteAll.FlatAppearance.BorderSize = 0;
            this.btn_deleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteAll.Location = new System.Drawing.Point(8, 21);
            this.btn_deleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(66, 37);
            this.btn_deleteAll.TabIndex = 1;
            this.btn_deleteAll.Text = "C";
            this.btn_deleteAll.UseVisualStyleBackColor = false;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_division.FlatAppearance.BorderSize = 0;
            this.btn_division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_division.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(242, 21);
            this.btn_division.Margin = new System.Windows.Forms.Padding(4);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(56, 37);
            this.btn_division.TabIndex = 16;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_mult.FlatAppearance.BorderSize = 0;
            this.btn_mult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mult.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mult.Location = new System.Drawing.Point(242, 64);
            this.btn_mult.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(56, 37);
            this.btn_mult.TabIndex = 15;
            this.btn_mult.Text = "x";
            this.btn_mult.UseVisualStyleBackColor = false;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_substract
            // 
            this.btn_substract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_substract.FlatAppearance.BorderSize = 0;
            this.btn_substract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_substract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_substract.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_substract.Location = new System.Drawing.Point(242, 107);
            this.btn_substract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(56, 37);
            this.btn_substract.TabIndex = 14;
            this.btn_substract.Text = "-";
            this.btn_substract.UseVisualStyleBackColor = false;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_eight.FlatAppearance.BorderSize = 0;
            this.btn_eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eight.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.Location = new System.Drawing.Point(81, 64);
            this.btn_eight.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(73, 37);
            this.btn_eight.TabIndex = 13;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = false;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_nine.FlatAppearance.BorderSize = 0;
            this.btn_nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nine.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.Location = new System.Drawing.Point(161, 64);
            this.btn_nine.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(74, 37);
            this.btn_nine.TabIndex = 12;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = false;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.Maroon;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.Location = new System.Drawing.Point(242, 195);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(56, 37);
            this.btn_equal.TabIndex = 11;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_sum.FlatAppearance.BorderSize = 0;
            this.btn_sum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sum.Location = new System.Drawing.Point(242, 151);
            this.btn_sum.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(56, 37);
            this.btn_sum.TabIndex = 10;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = false;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_seven.FlatAppearance.BorderSize = 0;
            this.btn_seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seven.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.Location = new System.Drawing.Point(8, 64);
            this.btn_seven.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(66, 37);
            this.btn_seven.TabIndex = 9;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = false;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_four
            // 
            this.btn_four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_four.FlatAppearance.BorderSize = 0;
            this.btn_four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_four.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.Location = new System.Drawing.Point(8, 107);
            this.btn_four.Margin = new System.Windows.Forms.Padding(4);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(66, 37);
            this.btn_four.TabIndex = 8;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = false;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_five
            // 
            this.btn_five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_five.FlatAppearance.BorderSize = 0;
            this.btn_five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_five.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.Location = new System.Drawing.Point(81, 107);
            this.btn_five.Margin = new System.Windows.Forms.Padding(4);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(73, 37);
            this.btn_five.TabIndex = 7;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = false;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_six
            // 
            this.btn_six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_six.FlatAppearance.BorderSize = 0;
            this.btn_six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_six.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.Location = new System.Drawing.Point(161, 107);
            this.btn_six.Margin = new System.Windows.Forms.Padding(4);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(74, 37);
            this.btn_six.TabIndex = 6;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = false;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_one
            // 
            this.btn_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_one.FlatAppearance.BorderSize = 0;
            this.btn_one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.Location = new System.Drawing.Point(8, 151);
            this.btn_one.Margin = new System.Windows.Forms.Padding(4);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(66, 37);
            this.btn_one.TabIndex = 5;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = false;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_two
            // 
            this.btn_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_two.FlatAppearance.BorderSize = 0;
            this.btn_two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_two.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.Location = new System.Drawing.Point(81, 151);
            this.btn_two.Margin = new System.Windows.Forms.Padding(4);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(73, 37);
            this.btn_two.TabIndex = 4;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = false;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_three
            // 
            this.btn_three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_three.FlatAppearance.BorderSize = 0;
            this.btn_three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_three.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.Location = new System.Drawing.Point(161, 151);
            this.btn_three.Margin = new System.Windows.Forms.Padding(4);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(74, 37);
            this.btn_three.TabIndex = 3;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = false;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_punto
            // 
            this.btn_punto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_punto.FlatAppearance.BorderSize = 0;
            this.btn_punto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_punto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_punto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_punto.Location = new System.Drawing.Point(8, 196);
            this.btn_punto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(66, 37);
            this.btn_punto.TabIndex = 2;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = false;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn_cero
            // 
            this.btn_cero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_cero.FlatAppearance.BorderSize = 0;
            this.btn_cero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cero.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cero.Location = new System.Drawing.Point(81, 196);
            this.btn_cero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cero.Name = "btn_cero";
            this.btn_cero.Size = new System.Drawing.Size(154, 37);
            this.btn_cero.TabIndex = 18;
            this.btn_cero.Text = "0";
            this.btn_cero.UseVisualStyleBackColor = false;
            this.btn_cero.Click += new System.EventHandler(this.btn_cero_Click);
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_data.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.White;
            this.txt_data.Location = new System.Drawing.Point(10, 40);
            this.txt_data.Margin = new System.Windows.Forms.Padding(4);
            this.txt_data.MaxLength = 3207;
            this.txt_data.Name = "txt_data";
            this.txt_data.ReadOnly = true;
            this.txt_data.Size = new System.Drawing.Size(308, 32);
            this.txt_data.TabIndex = 1;
            this.txt_data.Text = "0";
            this.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.Location = new System.Drawing.Point(217, 40);
            this.lbl_history.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(0, 15);
            this.lbl_history.TabIndex = 2;
            this.lbl_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(326, 350);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vic_Calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn_cero;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label lbl_history;
    }
}

