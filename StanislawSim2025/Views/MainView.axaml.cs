using Avalonia.Controls;
using Avalonia.Interactivity;

namespace StanislawSim2025.Views;

public partial class MainView : UserControl
{
    int anime=0;
    int inc = 1;
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        anime += inc;
        aTB.Text="Obejrzałeś "+anime+" anime dziewczynek";
    }

    private void Upgd1_OnClick(object? sender, RoutedEventArgs e)
    {
        if (anime >= 50)
        {
            anime -= 50;
            aTB.Text="Obejrzałeś "+anime+" anime dziewczynek";
            inc += 2;
            upgradePanel.Children.Remove(upg1);
        }
    }

    private void Upgd2_OnClick(object? sender, RoutedEventArgs e)
    {
        if (anime >= 175)
        {
            anime -= 175;
            aTB.Text="Obejrzałeś "+anime+" anime dziewczynek";
            inc += 3;
            upgradePanel.Children.Remove(upg2);
        }
    }
}