# FigureArea
C# library that allows users to create geometric figures and calculate their areas 
## Available Figures
* Triangle
  * created with 3 lengths of its sides
  * also supports checking for being a right angle triangle
* Circle
  * created with length of its radius
* Square
  * created with length of one side
# Usage
## Create a figure
Start with creating an instance of the provided service
```
IFigureAreaService figureArea = new FigureAreaService();
```
Then you can create a figure like this:
```
Circle circle = figureArea.CreateCircle(2);
```
## Calculate the area
Just use 
```
figureArea.CalculateArea(figure);
```
where "figure" can be any available figure
# Testing
the code was tested using xUnit
# Author
Kovregin Nikolai @nikovr
