﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace StanislawSim2025.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Welcome to Avalonia!";
}