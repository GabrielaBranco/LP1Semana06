<!-- 
Color
[
    - _red: byte
    - _green: byte
    - _blue: byte
    - _alpha: byte
    + Rgb: string
____________________________________________________________
    + Color(int red, int green, int blue, int alpha)
    + Color(int red, int green, int blue)
    + GetGrey(): byte
    - SetColor(int color): byte
]

Sphere
[
    - Color: Color
    - _radius: byte
    - thrownTimes: byte
    + ThrownTimes: byte
____________________________________________________________
    + Sphere(Color color, int radius)
    + Pop(): void
    + Thrown(): void
]
 -->