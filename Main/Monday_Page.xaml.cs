using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

struct value_change_flags {
    public bool read_box;
    public bool noun_box;
    public bool txt0_box;
    public bool txt1_box;
    public bool txt2_box;
    public bool txt3_box;
    public bool txt4_box;
}

namespace Main {

    public sealed partial class Monday_Page : Page {

        /* Local variables */
        int cnt_progress_bar_maximum_must = 0;
        int cnt_progress_bar_value_must = 0;
        int cnt_progress_bar_maximum_optional = 0;
        int cnt_progress_bar_value_optional = 0;
        /* ------------------------------ */

        /* Structs */
        value_change_flags value_flags;

        public Monday_Page() { 
            this.InitializeComponent();
            ElementSoundPlayer.State = ElementSoundPlayerState.On;

            /* Initial progress bar states */
            _day_progressbar.Maximum = 1;
            _day_progressbar.Value = 0;
            /* ------------------------------ */
        }
        private void read_pages_nr_box_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args) {
            if ((read_pages_nr_box.Value != 0) && (value_flags.read_box == false)) {
                _day_progressbar.Maximum += 1;
                cnt_progress_bar_maximum_must += 1;

                /* Only increment progress bar if value above threshold (10) currently */
                if (read_pages_nr_box.Value >= 10) {
                    _day_progressbar.Value += 1;
                    cnt_progress_bar_value_must += 1;
                }
                value_flags.read_box = true;
            } else {
                //do nothing
            }
        }

        private void nouns_learned_nr_box_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args) {
            if ((nouns_learned_nr_box.Value != 0) && (value_flags.noun_box = false)) {
                _day_progressbar.Maximum += 1;
                cnt_progress_bar_maximum_must += 1;

                /* Only increment progress bar if value above threshold (5) currently */
                if (nouns_learned_nr_box.Value >= 5) {
                    _day_progressbar.Value += 1;
                    cnt_progress_bar_value_must += 1;
                }
                value_flags.noun_box = true;
            } else {
                // do nothing
            }
        }

        private void exercise_check_box_Checked(object sender, RoutedEventArgs e) { 
            ElementSoundPlayer.Play(ElementSoundKind.Focus);
            if (_day_progressbar.Value <= _day_progressbar.Maximum) {
                _day_progressbar.Value += 1;
                cnt_progress_bar_value_must += 1;
            }
        }
        private void exercise_check_box_Unchecked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= 1;
                cnt_progress_bar_value_must -= 1;
            }
        }

        private void refresh_button_1_Click(object sender, RoutedEventArgs e) {
            /* Refresh "Tasks that must be completed" */
            if ((read_pages_nr_box.Value != double.NaN)) {
                read_pages_nr_box.Value = double.NaN;
                nouns_learned_nr_box.Value = double.NaN;
            }

            if (exercise_check_box.IsChecked == true) {
                exercise_check_box.IsChecked = false;
            }

            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= cnt_progress_bar_value_must;
                _day_progressbar.Maximum -= cnt_progress_bar_maximum_must;
                cnt_progress_bar_value_must = 0;
                cnt_progress_bar_maximum_must = 0;
            }
        }

        private void refresh_button_2_Click(object sender, RoutedEventArgs e) {
            /* Refresh "Tasks that must be completed" */
            if (Chkbox_row_0.IsChecked == true) {
                Chkbox_row_0.IsChecked = false;
            }

            if (Chkbox_row_1.IsChecked == true) {
                Chkbox_row_1.IsChecked = false;
            }

            if (Chkbox_row_2.IsChecked == true) {
                Chkbox_row_2.IsChecked = false;
            }

            if (Chkbox_row_3.IsChecked == true) {
                Chkbox_row_3.IsChecked = false;
            }

            if (Chkbox_row_4.IsChecked == true) {
                Chkbox_row_4.IsChecked = false;
            }

            if (!String.IsNullOrEmpty(Txtbox_row_0.Text)) {
                Txtbox_row_0.Text = String.Empty;
            }

            if (!String.IsNullOrEmpty(Txtbox_row_1.Text)) {
                Txtbox_row_1.Text = String.Empty;
            }

            if (!String.IsNullOrEmpty(Txtbox_row_2.Text)) {
                Txtbox_row_2.Text = String.Empty;
            }

            if (!String.IsNullOrEmpty(Txtbox_row_3.Text)) {
                Txtbox_row_3.Text = String.Empty;
            }

            if (!String.IsNullOrEmpty(Txtbox_row_4.Text)) {
                Txtbox_row_4.Text = String.Empty;
            }

            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= cnt_progress_bar_value_optional;
                _day_progressbar.Maximum -= cnt_progress_bar_maximum_optional;
                cnt_progress_bar_value_optional = 0;
                cnt_progress_bar_maximum_optional = 0;
            }
        }

        private void read_pages_nr_box_PointerPressed(object sender, PointerRoutedEventArgs e) {

        }

        /* ---------------------------------------------TEXTBOX0----------------------------------------------------------------*/
        private void Txtbox_row_0_SelectionChanged(object sender, RoutedEventArgs e) {
            if (!String.IsNullOrEmpty(Txtbox_row_0.Text)) {
                Chkbox_row_0.IsEnabled = true;

                /* Change value only once */
                if (value_flags.txt0_box == false) {
                    _day_progressbar.Maximum += 1;
                    cnt_progress_bar_maximum_optional += 1;
                    value_flags.txt0_box = true;
                }
            } else {
                Chkbox_row_0.IsEnabled = false;
            }
        }

        private void Chkbox_row_0_Checked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.Focus);
            if (_day_progressbar.Value <= _day_progressbar.Maximum) {
                _day_progressbar.Value += 1;
                cnt_progress_bar_value_optional += 1;
            }
            Txtbox_row_0.IsEnabled = false;
        }

        private void Chkbox_row_0_Unchecked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= 1;
                cnt_progress_bar_value_optional -= 1;
            }
            Txtbox_row_0.IsEnabled = true;
        }

        /* ---------------------------------------------TEXTBOX1----------------------------------------------------------------*/
        private void Txtbox_row_1_SelectionChanged(object sender, RoutedEventArgs e) {
            if (!String.IsNullOrEmpty(Txtbox_row_0.Text)) {
                Chkbox_row_1.IsEnabled = true;

                /* Change value only once */
                if (value_flags.txt1_box == false) {
                    _day_progressbar.Maximum += 1;
                    cnt_progress_bar_maximum_optional += 1;
                    value_flags.txt1_box = true;
                }
            } else {
                Chkbox_row_1.IsEnabled = false;
            }
        }

        private void Chkbox_row_1_Checked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.Focus);
            if (_day_progressbar.Value <= _day_progressbar.Maximum) {
                _day_progressbar.Value += 1;
                cnt_progress_bar_value_optional += 1;
            }
            Txtbox_row_1.IsEnabled = false;
        }

        private void Chkbox_row_1_Unchecked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= 1;
                cnt_progress_bar_value_optional -= 1;
            }
            Txtbox_row_1.IsEnabled = true;
        }

        /* ---------------------------------------------TEXTBOX2----------------------------------------------------------------*/
        private void Txtbox_row_2_SelectionChanged(object sender, RoutedEventArgs e) {
            if (!String.IsNullOrEmpty(Txtbox_row_0.Text)) {
                Chkbox_row_2.IsEnabled = true;

                /* Change value only once */
                if (value_flags.txt2_box == false) {
                    _day_progressbar.Maximum += 1;
                    cnt_progress_bar_maximum_optional += 1;
                    value_flags.txt2_box = true;
                }
            } else {
                Chkbox_row_2.IsEnabled = false;
            }
        }

        private void Chkbox_row_2_Checked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.Focus);
            if (_day_progressbar.Value <= _day_progressbar.Maximum) {
                _day_progressbar.Value += 1;
                cnt_progress_bar_value_optional += 1;
            }
            Txtbox_row_2.IsEnabled = false;
        }

        private void Chkbox_row_2_Unchecked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= 1;
                cnt_progress_bar_value_optional -= 1;
            }
            Txtbox_row_2.IsEnabled = true;
        }

        /* ---------------------------------------------TEXTBOX3----------------------------------------------------------------*/
        private void Txtbox_row_3_SelectionChanged(object sender, RoutedEventArgs e) {
            if (!String.IsNullOrEmpty(Txtbox_row_3.Text)) {
                Chkbox_row_3.IsEnabled = true;

                /* Change value only once */
                if (value_flags.txt3_box == false) {
                    _day_progressbar.Maximum += 1;
                    cnt_progress_bar_maximum_optional += 1;
                    value_flags.txt3_box = true;
                }
            } else {
                Chkbox_row_3.IsEnabled = false;
            }
        }

        private void Chkbox_row_3_Checked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value += 1;
                cnt_progress_bar_value_optional += 1;
            }
            Txtbox_row_3.IsEnabled = false;
        }

        private void Chkbox_row_3_Unchecked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= 1;
                cnt_progress_bar_value_optional -= 1;
            }
            Txtbox_row_3.IsEnabled = true;
        }

        /* ---------------------------------------------TEXTBOX4----------------------------------------------------------------*/
        private void Txtbox_row_4_SelectionChanged(object sender, RoutedEventArgs e) {
            if (!String.IsNullOrEmpty(Txtbox_row_4.Text)) {
                Chkbox_row_4.IsEnabled = true;

                /* Change value only once */
                if (value_flags.txt4_box == false) {
                    _day_progressbar.Maximum += 1;
                    cnt_progress_bar_maximum_optional += 1;
                    value_flags.txt4_box = true;
                }
            } else {
                Chkbox_row_4.IsEnabled = false;
            }
        }

        private void Chkbox_row_4_Checked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value += 1;
                cnt_progress_bar_value_optional += 1;
            }
            Txtbox_row_4.IsEnabled = false;
        }

        private void Chkbox_row_4_Unchecked(object sender, RoutedEventArgs e) {
            ElementSoundPlayer.Play(ElementSoundKind.GoBack);
            if (_day_progressbar.Value != 0) {
                _day_progressbar.Value -= 1;
                cnt_progress_bar_value_optional -= 1;
            }
            Txtbox_row_4.IsEnabled = true;
        }
    }
}
