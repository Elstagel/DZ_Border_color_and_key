using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BorderKey
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();



		}



		private void Window_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.Key == Key.LeftShift)                                     //так тоже работает )
			{
				ShiftBorder.Background = Brushes.Green;

			}
			if (Keyboard.Modifiers == ModifierKeys.Control)
			{
				CtrlBorder.Background = Brushes.Green;
			}
			if (e.Key==Key.Space)
			{
				AltBorder.Background = Brushes.Green;
			}

			if (Keyboard.Modifiers == ModifierKeys.None && e.Key != Key.Space)
			{
				KeyTextBlock.Text = e.Key.ToString();

			}

		}

		private void Window_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.LeftShift)                                                 //так тоже работает )
			{
				ShiftBorder.Background = Brushes.SandyBrown;
			}
			if (Keyboard.Modifiers != ModifierKeys.Control)
			{
				CtrlBorder.Background = Brushes.SandyBrown;
			}
			if (e.Key == Key.Space)
			{
				AltBorder.Background = Brushes.SandyBrown;
			}
				KeyTextBlock.Text = null;
		}


		public void Enter()
		{
			if (IsMouseOver)
			{
				YellowBorder.Background = Brushes.Blue;
				BlueBorder.Background = Brushes.Yellow;
				RedBorder.Background = Brushes.Turquoise;
				GreenBorder.Background = Brushes.Purple;
			}

		}

		public void Leave()
		{
			if (IsMouseOver)
			{
				YellowBorder.Background = Brushes.Yellow;
				BlueBorder.Background = Brushes.Blue;
				RedBorder.Background = Brushes.Red;
				GreenBorder.Background = Brushes.Green;
			}

		}

		private void YellowBorder_MouseEnter_1(object sender, MouseEventArgs e)
		{
			Enter();
		}

		private void YellowBorder_MouseLeave(object sender, MouseEventArgs e)
		{
			Leave();
		}

		private void BlueBorder_MouseEnter(object sender, MouseEventArgs e)
		{
			Leave();
		}

		private void BlueBorder_MouseLeave(object sender, MouseEventArgs e)
		{
			Enter();
		}

		private void GreenBorder_MouseEnter(object sender, MouseEventArgs e)
		{
			Leave();
		}

		private void GreenBorder_MouseLeave(object sender, MouseEventArgs e)
		{
			Enter();
		}

		private void RedBorder_MouseEnter(object sender, MouseEventArgs e)
		{
			Leave();

		}

		private void RedBorder_MouseLeave(object sender, MouseEventArgs e)
		{
			Enter();
		}

	}
}