namespace Figury
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_prawy = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kwadrat1 = new Figury.Kwadrat();
            this.okrag1 = new Figury.Okrag();
            this.trojkat1 = new Figury.Trojkat();
            this.panel_lewy = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stoper_label = new System.Windows.Forms.Label();
            this.poziom_label = new System.Windows.Forms.Label();
            this.button_end_game = new System.Windows.Forms.Button();
            this.panel_dolny = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comparison_site = new System.Windows.Forms.PictureBox();
            this.komunikat_label = new System.Windows.Forms.Label();
            this.button_next_lvl = new System.Windows.Forms.Button();
            this.kwadrat_label = new System.Windows.Forms.Label();
            this.okrag_label = new System.Windows.Forms.Label();
            this.trojkat_label = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.next_lvl_label = new System.Windows.Forms.Label();
            this.panel_end_game = new System.Windows.Forms.Panel();
            this.restart_button = new System.Windows.Forms.Button();
            this.label_pozostale_poziomy = new System.Windows.Forms.Label();
            this.label_pokonane_poziomy = new System.Windows.Forms.Label();
            this.label_liczba_bledow = new System.Windows.Forms.Label();
            this.label_czas_koncowy = new System.Windows.Forms.Label();
            this.label_end_game = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kwadrat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okrag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trojkat1)).BeginInit();
            this.panel_dolny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comparison_site)).BeginInit();
            this.panel_end_game.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_prawy
            // 
            this.panel_prawy.BackColor = System.Drawing.SystemColors.Control;
            this.panel_prawy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_prawy.Location = new System.Drawing.Point(789, 413);
            this.panel_prawy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_prawy.Name = "panel_prawy";
            this.panel_prawy.Size = new System.Drawing.Size(315, 275);
            this.panel_prawy.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 358);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // kwadrat1
            // 
            this.kwadrat1.BackColor = System.Drawing.Color.Transparent;
            this.kwadrat1.Compared = false;
            this.kwadrat1.Location = new System.Drawing.Point(157, 138);
            this.kwadrat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kwadrat1.Name = "kwadrat1";
            this.kwadrat1.Size = new System.Drawing.Size(150, 150);
            this.kwadrat1.TabIndex = 3;
            this.kwadrat1.TabStop = false;
            this.kwadrat1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Figura_MouseUp);
            // 
            // okrag1
            // 
            this.okrag1.BackColor = System.Drawing.Color.Transparent;
            this.okrag1.Compared = false;
            this.okrag1.Location = new System.Drawing.Point(524, 138);
            this.okrag1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okrag1.Name = "okrag1";
            this.okrag1.Size = new System.Drawing.Size(150, 150);
            this.okrag1.TabIndex = 4;
            this.okrag1.TabStop = false;
            this.okrag1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Figura_MouseUp);
            // 
            // trojkat1
            // 
            this.trojkat1.BackColor = System.Drawing.Color.Transparent;
            this.trojkat1.Compared = false;
            this.trojkat1.Location = new System.Drawing.Point(865, 138);
            this.trojkat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trojkat1.Name = "trojkat1";
            this.trojkat1.Size = new System.Drawing.Size(150, 150);
            this.trojkat1.TabIndex = 5;
            this.trojkat1.TabStop = false;
            this.trojkat1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Figura_MouseUp);
            // 
            // panel_lewy
            // 
            this.panel_lewy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_lewy.Location = new System.Drawing.Point(73, 413);
            this.panel_lewy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_lewy.Name = "panel_lewy";
            this.panel_lewy.Size = new System.Drawing.Size(315, 275);
            this.panel_lewy.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stoper_label
            // 
            this.stoper_label.AutoSize = true;
            this.stoper_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stoper_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stoper_label.Location = new System.Drawing.Point(1040, 33);
            this.stoper_label.Name = "stoper_label";
            this.stoper_label.Size = new System.Drawing.Size(64, 28);
            this.stoper_label.TabIndex = 7;
            this.stoper_label.Text = "00:00";
            // 
            // poziom_label
            // 
            this.poziom_label.AutoSize = true;
            this.poziom_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poziom_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poziom_label.Location = new System.Drawing.Point(73, 32);
            this.poziom_label.Name = "poziom_label";
            this.poziom_label.Size = new System.Drawing.Size(99, 28);
            this.poziom_label.TabIndex = 8;
            this.poziom_label.Text = "Poziom: 1";
            // 
            // button_end_game
            // 
            this.button_end_game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_end_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_end_game.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_end_game.Location = new System.Drawing.Point(930, 726);
            this.button_end_game.Name = "button_end_game";
            this.button_end_game.Size = new System.Drawing.Size(84, 36);
            this.button_end_game.TabIndex = 9;
            this.button_end_game.Text = "Zakończ grę";
            this.button_end_game.UseVisualStyleBackColor = true;
            this.button_end_game.Click += new System.EventHandler(this.button_end_game_Click);
            // 
            // panel_dolny
            // 
            this.panel_dolny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_dolny.Controls.Add(this.label3);
            this.panel_dolny.Controls.Add(this.label2);
            this.panel_dolny.Controls.Add(this.label1);
            this.panel_dolny.Location = new System.Drawing.Point(401, 735);
            this.panel_dolny.Name = "panel_dolny";
            this.panel_dolny.Size = new System.Drawing.Size(387, 36);
            this.panel_dolny.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(257, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "333";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "222";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "111";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number_MouseDown);
            // 
            // comparison_site
            // 
            this.comparison_site.Location = new System.Drawing.Point(524, 472);
            this.comparison_site.Name = "comparison_site";
            this.comparison_site.Size = new System.Drawing.Size(150, 150);
            this.comparison_site.TabIndex = 11;
            this.comparison_site.TabStop = false;
            // 
            // komunikat_label
            // 
            this.komunikat_label.AutoSize = true;
            this.komunikat_label.Location = new System.Drawing.Point(454, 663);
            this.komunikat_label.Name = "komunikat_label";
            this.komunikat_label.Size = new System.Drawing.Size(291, 15);
            this.komunikat_label.TabIndex = 15;
            this.komunikat_label.Text = "Niepoprawna liczba figur w polach do porównywania.\r\n";
            this.komunikat_label.Visible = false;
            // 
            // button_next_lvl
            // 
            this.button_next_lvl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_next_lvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next_lvl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_next_lvl.Location = new System.Drawing.Point(1020, 726);
            this.button_next_lvl.Name = "button_next_lvl";
            this.button_next_lvl.Size = new System.Drawing.Size(84, 36);
            this.button_next_lvl.TabIndex = 16;
            this.button_next_lvl.Text = "Sprawdź";
            this.button_next_lvl.UseVisualStyleBackColor = true;
            this.button_next_lvl.Click += new System.EventHandler(this.button_next_lvl_Click);
            // 
            // kwadrat_label
            // 
            this.kwadrat_label.AllowDrop = true;
            this.kwadrat_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kwadrat_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kwadrat_label.Location = new System.Drawing.Point(174, 109);
            this.kwadrat_label.Name = "kwadrat_label";
            this.kwadrat_label.Size = new System.Drawing.Size(115, 27);
            this.kwadrat_label.TabIndex = 17;
            this.kwadrat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kwadrat_label.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_DragDrop);
            this.kwadrat_label.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_DragEnter);
            // 
            // okrag_label
            // 
            this.okrag_label.AllowDrop = true;
            this.okrag_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.okrag_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okrag_label.Location = new System.Drawing.Point(541, 109);
            this.okrag_label.Name = "okrag_label";
            this.okrag_label.Size = new System.Drawing.Size(115, 27);
            this.okrag_label.TabIndex = 18;
            this.okrag_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okrag_label.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_DragDrop);
            this.okrag_label.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_DragEnter);
            // 
            // trojkat_label
            // 
            this.trojkat_label.AllowDrop = true;
            this.trojkat_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trojkat_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trojkat_label.Location = new System.Drawing.Point(883, 109);
            this.trojkat_label.Name = "trojkat_label";
            this.trojkat_label.Size = new System.Drawing.Size(115, 27);
            this.trojkat_label.TabIndex = 19;
            this.trojkat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trojkat_label.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_DragDrop);
            this.trojkat_label.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_DragEnter);
            // 
            // button_reset
            // 
            this.button_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_reset.Location = new System.Drawing.Point(840, 726);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(84, 36);
            this.button_reset.TabIndex = 20;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // next_lvl_label
            // 
            this.next_lvl_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.next_lvl_label.Location = new System.Drawing.Point(174, 65);
            this.next_lvl_label.Name = "next_lvl_label";
            this.next_lvl_label.Size = new System.Drawing.Size(864, 28);
            this.next_lvl_label.TabIndex = 21;
            this.next_lvl_label.Text = "Komunikat po naciśnięciu \"Sprawdź\"";
            this.next_lvl_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_end_game
            // 
            this.panel_end_game.AutoScroll = true;
            this.panel_end_game.BackColor = System.Drawing.Color.LightGray;
            this.panel_end_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_end_game.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_end_game.Controls.Add(this.restart_button);
            this.panel_end_game.Controls.Add(this.label_pozostale_poziomy);
            this.panel_end_game.Controls.Add(this.label_pokonane_poziomy);
            this.panel_end_game.Controls.Add(this.label_liczba_bledow);
            this.panel_end_game.Controls.Add(this.label_czas_koncowy);
            this.panel_end_game.Controls.Add(this.label_end_game);
            this.panel_end_game.Location = new System.Drawing.Point(394, 109);
            this.panel_end_game.Name = "panel_end_game";
            this.panel_end_game.Size = new System.Drawing.Size(389, 357);
            this.panel_end_game.TabIndex = 22;
            this.panel_end_game.Visible = false;
            // 
            // restart_button
            // 
            this.restart_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.restart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_button.Location = new System.Drawing.Point(130, 277);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(137, 41);
            this.restart_button.TabIndex = 5;
            this.restart_button.Text = "Zacznij od nowa";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // label_pozostale_poziomy
            // 
            this.label_pozostale_poziomy.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_pozostale_poziomy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_pozostale_poziomy.Location = new System.Drawing.Point(0, 194);
            this.label_pozostale_poziomy.Name = "label_pozostale_poziomy";
            this.label_pozostale_poziomy.Size = new System.Drawing.Size(387, 39);
            this.label_pozostale_poziomy.TabIndex = 4;
            this.label_pozostale_poziomy.Text = "Liczba pozostałych poziomów: ";
            // 
            // label_pokonane_poziomy
            // 
            this.label_pokonane_poziomy.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_pokonane_poziomy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_pokonane_poziomy.Location = new System.Drawing.Point(0, 155);
            this.label_pokonane_poziomy.Name = "label_pokonane_poziomy";
            this.label_pokonane_poziomy.Size = new System.Drawing.Size(387, 39);
            this.label_pokonane_poziomy.TabIndex = 3;
            this.label_pokonane_poziomy.Text = "Liczba pokonanych poziomów: ";
            // 
            // label_liczba_bledow
            // 
            this.label_liczba_bledow.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_liczba_bledow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_liczba_bledow.Location = new System.Drawing.Point(0, 116);
            this.label_liczba_bledow.Name = "label_liczba_bledow";
            this.label_liczba_bledow.Size = new System.Drawing.Size(387, 39);
            this.label_liczba_bledow.TabIndex = 2;
            this.label_liczba_bledow.Text = "Liczba błędów: ";
            // 
            // label_czas_koncowy
            // 
            this.label_czas_koncowy.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_czas_koncowy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_czas_koncowy.Location = new System.Drawing.Point(0, 77);
            this.label_czas_koncowy.Name = "label_czas_koncowy";
            this.label_czas_koncowy.Size = new System.Drawing.Size(387, 39);
            this.label_czas_koncowy.TabIndex = 1;
            this.label_czas_koncowy.Text = "Czas całej gry: ";
            // 
            // label_end_game
            // 
            this.label_end_game.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_end_game.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_end_game.Location = new System.Drawing.Point(0, 0);
            this.label_end_game.Name = "label_end_game";
            this.label_end_game.Size = new System.Drawing.Size(387, 77);
            this.label_end_game.TabIndex = 0;
            this.label_end_game.Text = "Gratulacje!\r\nUdało Ci się przejść wszystkie poziomy! \r\nOto garść Twoich statystyk" +
    ":";
            this.label_end_game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.next_lvl_label);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.trojkat_label);
            this.Controls.Add(this.okrag_label);
            this.Controls.Add(this.kwadrat_label);
            this.Controls.Add(this.button_next_lvl);
            this.Controls.Add(this.komunikat_label);
            this.Controls.Add(this.comparison_site);
            this.Controls.Add(this.panel_dolny);
            this.Controls.Add(this.button_end_game);
            this.Controls.Add(this.poziom_label);
            this.Controls.Add(this.stoper_label);
            this.Controls.Add(this.panel_lewy);
            this.Controls.Add(this.trojkat1);
            this.Controls.Add(this.okrag1);
            this.Controls.Add(this.kwadrat1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_prawy);
            this.Controls.Add(this.panel_end_game);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 850);
            this.MinimumSize = new System.Drawing.Size(1200, 850);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kwadrat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okrag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trojkat1)).EndInit();
            this.panel_dolny.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comparison_site)).EndInit();
            this.panel_end_game.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_prawy;
        private System.Windows.Forms.TextBox textBox1;
        private Figury.Kwadrat kwadrat1;
        private Okrag okrag1;
        private Trojkat trojkat1;
        private System.Windows.Forms.Panel panel_lewy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label stoper_label;
        private System.Windows.Forms.Label poziom_label;
        private System.Windows.Forms.Button button_end_game;
        private System.Windows.Forms.Panel panel_dolny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox comparison_site;
        private System.Windows.Forms.Label komunikat_label;
        private System.Windows.Forms.Button button_next_lvl;
        private System.Windows.Forms.Label kwadrat_label;
        private System.Windows.Forms.Label okrag_label;
        private System.Windows.Forms.Label trojkat_label;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label next_lvl_label;
        private System.Windows.Forms.Panel panel_end_game;
        private System.Windows.Forms.Label label_end_game;
        private System.Windows.Forms.Label label_pozostale_poziomy;
        private System.Windows.Forms.Label label_pokonane_poziomy;
        private System.Windows.Forms.Label label_liczba_bledow;
        private System.Windows.Forms.Label label_czas_koncowy;
        private System.Windows.Forms.Button restart_button;
    }
}
