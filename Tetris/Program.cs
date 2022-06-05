// See https://aka.ms/new-console-template for more information

using Tetris;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40, 30);

Figure[] f = new Figure[2];
f[0] = new Square(2, 5, '*');
f[1] = new Stick(8, 12, '*');


//Square s = new Square(2, 5, '*');
//s.Draw();

//Stick st = new Stick(8, 12, '*');
//st.Draw();

foreach (Figure fig in f)
{
    fig.Draw();

}



Point p1 = new Point(2,3, '*');

p1.Draw();

Point p2 = new Point()
{
    x = 4,
    y = 5,
    c = '#'
};
p2.Draw();

Console.ReadLine();


