# How to Bind Data for WPF Wizard Control
## Overview
This sample demonstrates how to bind data to the Syncfusion WPF Wizard control. The Wizard control is designed to guide users through a series of steps in a structured and user-friendly manner. It is commonly used in:
- Installation processes
- Multi-step forms
- Configuration wizards

## Features
- Bind to custom objects and collections.
- Dynamically generate wizard pages based on data.
- Navigation control between steps.
- Supports validation and conditional logic for transitions.

## Implementation Steps
### 1. Create Model Class
```C#
public class Model : NotificationObject
{
    private string title;
    public string Title
    {
        get => title;
        set { title = value; RaisePropertyChanged("Title"); }
    }

    private string content;
    public string Content
    {
        get => content;
        set { content = value; RaisePropertyChanged("Description"); }
    }
}
```

### 2. Create ViewModel Class
```C#
public class ViewModel : NotificationObject
{
    public ObservableCollection<Model> PageItems { get; set; }

    public ViewModel()
    {
        PageItems = new ObservableCollection<Model>();
        PopulatePageItems();
    }

    private void PopulatePageItems()
    {
        PageItems.Add(new Model { Title = "Wizard Control", Content = "The WPF Wizard helps build dialogs with multiple pages." });
        PageItems.Add(new Model { Title = "Pages", Content = "Wizard control provides start, regular, and finish pages." });
        PageItems.Add(new Model { Title = "Buttons", Content = "Pages can display Back, Next, Finish, and Cancel buttons." });
        PageItems.Add(new Model { Title = "Navigation", Content = "Demonstrates navigation between pages in strict order." });
    }
}
```

### 3. Bind ViewModel in XAML
```XAML
<Window.DataContext>
    <local:ViewModel/>
</Window.DataContext>

<Window.Resources>
    <Style x:Key="WizardPageStyle" TargetType="syncfusion:WizardPage">
        <Setter Property="Title" Value="{Binding Title}"/>
        <Setter Property="PageType" Value="Exterior"/>
    </Style>
</Window.Resources>

<Grid>
    <syncfusion:WizardControl x:Name="wizardcontrol"
                               ItemContainerStyle="{StaticResource WizardPageStyle}"
                               ItemsSource="{Binding PageItems}">
        <syncfusion:WizardControl.ItemTemplate>
            <DataTemplate>
                <TextBlock Text="{Binding Content}" TextWrapping="Wrap"/>
            </DataTemplate>
        </syncfusion:WizardControl.ItemTemplate>
    </syncfusion:WizardControl>
</Grid>
```

## Why This Approach?
- Enables dynamic content generation.
- Simplifies binding logic for multi-step workflows.
- Ideal for guided processes in WPF applications.
