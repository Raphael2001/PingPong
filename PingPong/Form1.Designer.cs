namespace PingPong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playground = new System.Windows.Forms.Panel();
            this.Made_by = new System.Windows.Forms.Label();
            this.BestName_lbl = new System.Windows.Forms.Label();
            this.BestPlayerN_lbl = new System.Windows.Forms.Label();
            this.bestpoints_lbl = new System.Windows.Forms.Label();
            this.bestscore_lbl = new System.Windows.Forms.Label();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.Points_lbl = new System.Windows.Forms.Label();
            this.Score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playground.Controls.Add(this.Made_by);
            this.playground.Controls.Add(this.BestName_lbl);
            this.playground.Controls.Add(this.BestPlayerN_lbl);
            this.playground.Controls.Add(this.bestpoints_lbl);
            this.playground.Controls.Add(this.bestscore_lbl);
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.Points_lbl);
            this.playground.Controls.Add(this.Score_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1096, 602);
            this.playground.TabIndex = 0;
            // 
            // Made_by
            // 
            this.Made_by.AutoSize = true;
            this.Made_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Made_by.Location = new System.Drawing.Point(366, 559);
            this.Made_by.Name = "Made_by";
            this.Made_by.Size = new System.Drawing.Size(266, 34);
            this.Made_by.TabIndex = 24;
            this.Made_by.Text = "Made by Raphael Aboohi";
            // 
            // BestName_lbl
            // 
            this.BestName_lbl.AutoSize = true;
            this.BestName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BestName_lbl.Location = new System.Drawing.Point(978, 9);
            this.BestName_lbl.Name = "BestName_lbl";
            this.BestName_lbl.Size = new System.Drawing.Size(0, 46);
            this.BestName_lbl.TabIndex = 9;
            // 
            // BestPlayerN_lbl
            // 
            this.BestPlayerN_lbl.AutoSize = true;
            this.BestPlayerN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BestPlayerN_lbl.Location = new System.Drawing.Point(610, 9);
            this.BestPlayerN_lbl.Name = "BestPlayerN_lbl";
            this.BestPlayerN_lbl.Size = new System.Drawing.Size(363, 46);
            this.BestPlayerN_lbl.TabIndex = 8;
            this.BestPlayerN_lbl.Text = "Best Player Name :";
            // 
            // bestpoints_lbl
            // 
            this.bestpoints_lbl.AutoSize = true;
            this.bestpoints_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bestpoints_lbl.Location = new System.Drawing.Point(499, 9);
            this.bestpoints_lbl.Name = "bestpoints_lbl";
            this.bestpoints_lbl.Size = new System.Drawing.Size(54, 59);
            this.bestpoints_lbl.TabIndex = 7;
            this.bestpoints_lbl.Text = "0";
            // 
            // bestscore_lbl
            // 
            this.bestscore_lbl.AutoSize = true;
            this.bestscore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bestscore_lbl.Location = new System.Drawing.Point(243, 9);
            this.bestscore_lbl.Name = "bestscore_lbl";
            this.bestscore_lbl.Size = new System.Drawing.Size(250, 46);
            this.bestscore_lbl.TabIndex = 6;
            this.bestscore_lbl.Text = "Best Score : ";
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gameover_lbl.Location = new System.Drawing.Point(241, 127);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(532, 354);
            this.gameover_lbl.TabIndex = 5;
            this.gameover_lbl.Text = "Game over\r\n\r\nF1 - Restart\r\nEsc - Exit\r\nF2 - High Score Table\r\nF3 - Ball Store";
            // 
            // Points_lbl
            // 
            this.Points_lbl.AutoSize = true;
            this.Points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Points_lbl.Location = new System.Drawing.Point(160, 9);
            this.Points_lbl.Name = "Points_lbl";
            this.Points_lbl.Size = new System.Drawing.Size(54, 59);
            this.Points_lbl.TabIndex = 4;
            this.Points_lbl.Text = "0";
            // 
            // Score_lbl
            // 
            this.Score_lbl.AutoSize = true;
            this.Score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Score_lbl.Location = new System.Drawing.Point(12, 9);
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.Size = new System.Drawing.Size(159, 46);
            this.Score_lbl.TabIndex = 3;
            this.Score_lbl.Text = "Score : ";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = global::PingPong.Properties.Resources.Red;
            this.ball.Location = new System.Drawing.Point(55, 151);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(353, 516);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racket.TabIndex = 1;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 602);
            this.Controls.Add(this.playground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Points_lbl;
        private System.Windows.Forms.Label Score_lbl;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Label bestpoints_lbl;
        private System.Windows.Forms.Label bestscore_lbl;
        private System.Windows.Forms.Label BestPlayerN_lbl;
        private System.Windows.Forms.Label BestName_lbl;
        private System.Windows.Forms.Label Made_by;
    }
}

