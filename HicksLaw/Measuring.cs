﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HicksLaw
{
    public partial class Measuring : Form
    {
        bool running;
        bool finished;
        Stopwatch stopwatch;
        Rectangle buttonRect;
        int curretnShownButtons = -1;
        long[][] times;
        List<int> countsLeft;
        int[] countsDone;
        Random rng;
        List<Button> buttons;
        Button correctButton;
        public Measuring()
        {
            InitializeComponent();
            running = false;
            finished = false;
            UpdateButtons();
            stopwatch = new Stopwatch();
            buttonRect = new Rectangle(5, textBox_prompt.Location.Y + textBox_prompt.Height + 5, Math.Max(30, 200 / Program.maxButtonsCurrent), 20);
            rng = new Random(DateTime.Now.Millisecond);
            Setup();
            PopulateButtons();
        }
        void Setup()
        {
            Size = new Size(buttonRect.Width * Program.maxButtonsCurrent + (Program.maxButtonsCurrent + 4) * buttonRect.X, Size.Height);
            MaximumSize = Size;
            MinimumSize = Size;
            times = new long[Program.maxButtonsCurrent][];
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = new long[Program.numOfTries];
            }
            countsLeft = new List<int>(Enumerable.Range(0, Program.maxButtonsCurrent));
            countsDone = new int[countsLeft.Count];

        }
        protected void PopulateButtons()
        {            
            buttons = new List<Button>();
            for (int i = 0; i < Program.maxButtonsCurrent; i++)
            {
                var b = new Button();
                b.Text = $"{i + 1}";
                b.Location = new Point(buttonRect.Width * i + buttonRect.X * (i + 1), buttonRect.Y);
                b.Size = new Size(buttonRect.Width, buttonRect.Height);
                b.Name = $"button_option{i + 1}";
                b.Click += Button_OptionClick;
                b.Visible = false;
                Controls.Add(b);
                buttons.Add(b);
            }
        }

        public void NewLottery(bool first=false, Button chosenButton=null)
        {
            if(first)
            {
                Setup();
            }
            else
            {
                if (chosenButton == correctButton)
                {
                    times[curretnShownButtons][countsDone[curretnShownButtons]] = stopwatch.ElapsedMilliseconds;
                    countsDone[curretnShownButtons] += 1;
                    if (countsDone[curretnShownButtons] >= Program.numOfTries)
                    {
                        countsLeft.Remove(curretnShownButtons);

                    }
                    if (countsLeft.Count == 0)
                    {
                        running = false;
                        for (int i = 0; i < buttons.Count; i++)
                        {
                            buttons[i].Visible = false;
                        }

                        UpdateButtons();
                        Program.UpdateResults(times);
                        return;
                    }
                }
            }

            
            curretnShownButtons = rng.Next(0, countsLeft.Count);
            curretnShownButtons = countsLeft[curretnShownButtons] + 1;
            var visableButtons = new List<Button>(buttons);
            int shownCount = Program.maxButtonsCurrent;
            for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Visible = true;
            }
            while(shownCount > curretnShownButtons)
            {
                var hide = rng.Next(0, buttons.Count);
                while(buttons[hide].Visible != true)
                {
                    hide += 1;
                    hide %= buttons.Count;
                }
                buttons[hide].Visible = false;
                visableButtons.Remove(buttons[hide]);
                shownCount -= 1;
            }
            correctButton = visableButtons[rng.Next(0, visableButtons.Count)];
            textBox_prompt.Text = correctButton.Text;
            curretnShownButtons -= 1;
            stopwatch.Restart();
        }

        private void UpdateButtons()
        {
            button_interrupt.Enabled = running;
            button_exitMeasuring.Enabled = !running;
            button_beginMeasuring.Enabled = !running;
        }

        private void Button_interrupt_Click(object sender, EventArgs e)
        {
            running = false;
            UpdateButtons();
        }

        private void Button_exitMeasuring_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_beginMeasuring_Click(object sender, EventArgs e)
        {
            running = true;
            UpdateButtons();
            NewLottery(true);
        }
        private void Button_OptionClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            NewLottery(chosenButton:b);
        }
    }
}