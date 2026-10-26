namespace ObjectOriented.Abstraction;

public class Human
{
    private int _posX;
    private int _posY;
    private int _speed;

    public Human(int posX, int posY, int speed)
    {
        _posX = posX;
        _posY = posY;
        _speed = speed;
    }

    public void MoveRight()
    {
        _posX += _speed;
    }

    public void MoveLeft()
    {
        _posX -= _speed;
    }

    public void MoveUp()
    {
        _posY += _speed;
    }

    public void MoveDown()
    {
        _posY -= _speed;
    }

    public (int X, int Y) GetPosition()
    {
        return (_posX, _posY);
    }
}
