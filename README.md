# GraphView

[GraphView](https://github.com/jjoe64/graphview) is a Graph Library for creating zoomable and scrollable line and bar graphs.

we convert .jar file to .DLL file for use in xamarin native android.

for more information: [Binding a .JAR](https://docs.microsoft.com/en-us/xamarin/android/platform/binding-java-library/binding-a-jar)

## Usage
1) first import GraphViewJarBinding.DLL file to your project references

2) add this code to your xml layout:
```xml
<com.jjoe64.graphview.GraphView
    android:id="@+id/graphView"
    android:layout_width="match_parent"
    android:layout_height="match_parent"/>
```

3) and then use graphView throughout the project:
```c#
GraphView graphView = FindViewById<GraphView>(Resource.Id.graphView);
```
