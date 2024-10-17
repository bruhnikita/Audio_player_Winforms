using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace Audio_player_Winforms
{
    public partial class MainForm : Form
    {
        private int currentTrackIndex = -1;
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;
        private List<string> playlist = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentTrackIndex > 0)
            {
                currentTrackIndex--;
                PlayCurrentTrack();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentTrackIndex < playlist.Count - 1)
            {
                currentTrackIndex++;
                PlayCurrentTrack();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wavePlayer?.Pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (currentTrackIndex < 0 || currentTrackIndex >= playlist.Count)
            {
                return;
            }

            if (wavePlayer != null)
            {
                wavePlayer.Stop();
                wavePlayer.Dispose();
            }

            wavePlayer = new WaveOut();
            audioFileReader = new AudioFileReader(playlist[currentTrackIndex]);
            wavePlayer.Init(audioFileReader);
            wavePlayer.Play();
        }

        private void PlayCurrentTrack()
        {
            if (currentTrackIndex < 0 || currentTrackIndex >= playlist.Count)
            {
                return;
            }

            btnPlay_Click(null, null);
        }

        private void musicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTrackIndex = musicListBox.SelectedIndex;
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(folderDialog.SelectedPath, "*.*")
                        .Where(f => f.EndsWith(".mp3") || f.EndsWith(".wav") || f.EndsWith(".aac")).ToArray();

                    playlist.Clear();
                    musicListBox.Items.Clear();

                    foreach (var file in files)
                    {
                        playlist.Add(file);
                        musicListBox.Items.Add(Path.GetFileName(file));
                    }

                    if (playlist.Count > 0)
                    {
                        currentTrackIndex = 0;
                        musicListBox.SelectedIndex = currentTrackIndex;
                    }
                }
            }
        }
    }
}
