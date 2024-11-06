# Add-and-Customize-Annotations-in-MAUI-Cartesian-Charts

This sample demonstrates how to add text, shapes, and view annotations. You will also see how to disable and customize annotations.

## Sample

```xaml
<chart:SfCartesianChart>

    <chart:SfCartesianChart.Title>
        <Label Text="Average Monthly Temperature" FontAttributes="Bold"
               HorizontalTextAlignment="Center" FontSize="20"/>
    </chart:SfCartesianChart.Title>
    
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis Interval="5">
            <chart:NumericalAxis.LabelStyle>
                <chart:ChartAxisLabelStyle LabelFormat="0'F" />
            </chart:NumericalAxis.LabelStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>

    <chart:SfCartesianChart.Annotations>
        <chart:ViewAnnotation X1="1.5" Y1="55">
            <chart:ViewAnnotation.View>
                <Image Source="cloudy.png" HeightRequest="100" WidthRequest="90"/>
            </chart:ViewAnnotation.View>
        </chart:ViewAnnotation>
    </chart:SfCartesianChart.Annotations>

    <chart:SplineSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Month"
                        YBindingPath="Temperature"/>
</chart:SfCartesianChart>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.

