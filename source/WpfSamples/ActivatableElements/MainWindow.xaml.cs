//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

namespace ActivatableElements
{
    using ActivatableElements;
    using EyeXFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using Tobii.EyeX.Framework;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Process.Start("C:\\SDKs\\TobiiEyeXSdk-DotNet-1.7.489\\source\\MinimalSamples\\MinimalGazeDataStream\\bin\\x86\\Debug\\MinimalGazeDataStream.exe");
            ReadSentences();
        }

        private List<string> sentences = new List<string>();
        private string message = "";

        private void ReadSentences()
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\phrases2.txt");

            foreach (string line in lines)
            {
                if (!line.Equals(""))
                {
                    sentences.Add(line);
                }
            }
        }

        private void Note_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var element = e.Source as FrameworkElement;
            if (null == element) { return; }

            var parent = element.TemplatedParent as FrameworkElement;
            if (null == parent) { return; }

            var clickedNote = parent.DataContext as Note;
            ((MainWindowModel)DataContext).ActivateNote(clickedNote);
        }

        private void Note_OnEyeXActivate(object sender, RoutedEventArgs e)
        {
            var element = e.Source as FrameworkElement;
            if (null == element) { return; }

            var clickedNote = element.DataContext as Note;
            ((MainWindowModel)DataContext).ActivateNote(clickedNote);
        }

        private void Button_OnEyeXActivate(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (null == button) { return; }

            if (button.Command != null)
            {
                button.Command.Execute(button);
            }
            else
            {
                button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent, button));
            }
        }

        private void RestoreWisdomButton_OnClick(object sender, RoutedEventArgs e)
        {
            ((MainWindowModel)DataContext).RestoreWisdom();
        }

        private void CloseCommand_OnExecuted(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CloseCommand_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void MainWindow_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightShift)
            {
                var currentApp = Application.Current as App;
                if (currentApp != null) currentApp.EyeXHost.TriggerActivation();
            }
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightShift)
            {
                var currentApp = Application.Current as App;
                if (currentApp != null) currentApp.EyeXHost.TriggerActivationModeOn();
            }
        }

        private void KeyButton_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            message += button.Content.ToString().ToLower();

            messageTextBox.Text = message;

            //((MainWindowModel)DataContext).WriteChar("a");
        }

        private void SpaceButton_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            message += " ";

            messageTextBox.Text = message;

            //((MainWindowModel)DataContext).WriteChar("a");
        }

        private void EnterButton_OnClick(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, sentences.Count - 1);

            sentenceTextBlock.Text = sentences[randomNumber];
            sentences.RemoveAt(randomNumber);

            message = "";
            messageTextBox.Text = message;
        }
        private void BackSpaceButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Button button = sender as Button;
            if (message.Length > 0)
            {
                message = message.Remove(message.Length - 1);
            }
            messageTextBox.Text = message;

        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
        }

    }
}
