using System.Windows.Forms;
using System.Drawing;

class CCircle
{ // Константи
    const int DefaultRadius = 50; // Радіус кола за замовчуванням, пікс
                                  // Поля
    private Graphics graphics;
    private int _radius; // Підтримуюче поле для властивості Radius
                         // Властивості
    public int X { get; set; } // Координата X центра кола
    public int Y { get; set; } // Координата Y центра кола
    public int Radius
    { // Радіус кола
        get
        {
            return _radius;
        }
        set
        {
            _radius = value >= 200 ? 200 : value;
            _radius = value <= 5 ? 5 : value;
        }
    }
    // Конструктор, створює об'єкт кола (для заданої поверхні
    // малювання GDI+) з заданими координатами.
    // Радіус кола приймається за замовчуванням
    public CCircle(Graphics graphics, int X, int Y)
    {
        this.graphics = graphics;
        this.X = X;
        this.Y = Y;
        this.Radius = DefaultRadius;
    }
    // Конструктор, створює об'єкт кола (для заданої поверхні
    // малювання GDI+) з заданими координатами та радіусом
    public CCircle(Graphics graphics, int X, int Y, int Radius)
    {
        this.graphics = graphics;
        this.X = X;
        this.Y = Y;
        this.Radius = Radius;
    }
    // Малює коло на поверхні малювання GDI+.
    // Параметри кола задає перо pen
    private void Draw(Pen pen)
    {

        Rectangle rectangle = new Rectangle(X - Radius, Y - Radius,
        2 * Radius, 2 * Radius);
        graphics.DrawEllipse(pen, rectangle);
    }
    // Показує коло (малює на поверхні малювання GDI+ кольором
    // переднього плану)
    public void Show()
    {
        Draw(Pens.Red);
    }
    // Приховує коло (малює на поверхні малювання GDI+ кольором фону)
    public void Hide()
    {
        Draw(Pens.White);
    }
    // Розширює коло: збільшує радіус на один піксель
    public void Expand()
    {
        Hide();
        Radius++;
        Show();
    }
    // Розширює коло: збільшує радіус на dR пікселів
    public void Expand(int dR)
    {
        Hide();
        Radius = Radius + dR;
        Show();
    }

    // Стискає коло: зменшує радіус на один піксель
    public void Collapse()
    {
        Hide();
        Radius--;
        Show();
    }
    // Стискає коло: зменшує радіус на dR пікселів
    public void Collapse(int dR)
    {
        Hide();
        Radius = Radius - dR;
        Show();
    }
    // Переміщує коло
    public void Move(int dX, int dY)
    {
        Hide();
        X = X + dX;
        Y = Y + dY;
        Show();
    }
} // Кінець оголошення класу

