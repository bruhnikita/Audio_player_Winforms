namespace Audio_player_Winforms
{
    partial class MainForm
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
            btnPlay = new Button();
            btnPause = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnOpenDir = new Button();
            panel1 = new Panel();
            musicListBox = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(2, 63);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(76, 23);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(83, 63);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(76, 23);
            btnPause.TabIndex = 1;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(164, 63);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(76, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(245, 63);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(76, 23);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnOpenDir
            // 
            btnOpenDir.Location = new Point(326, 63);
            btnOpenDir.Name = "btnOpenDir";
            btnOpenDir.Size = new Size(76, 23);
            btnOpenDir.TabIndex = 4;
            btnOpenDir.Text = "Open dir";
            btnOpenDir.UseVisualStyleBackColor = true;
            btnOpenDir.Click += btnOpenDir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOpenDir);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPause);
            panel1.Controls.Add(btnPlay);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 358);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 92);
            panel1.TabIndex = 0;
            // 
            // musicListBox
            // 
            musicListBox.Dock = DockStyle.Fill;
            musicListBox.FormattingEnabled = true;
            musicListBox.ItemHeight = 15;
            musicListBox.Location = new Point(0, 0);
            musicListBox.Name = "musicListBox";
            musicListBox.Size = new Size(800, 358);
            musicListBox.TabIndex = 1;
            musicListBox.SelectedIndexChanged += musicListBox_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(musicListBox);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Аудио плеер";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnPause;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnOpenDir;
        private Panel panel1;
        private ListBox musicListBox;
        private OpenFileDialog openFileDialog1;
    }
}
