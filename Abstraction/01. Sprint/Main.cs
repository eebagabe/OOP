namespace ObjectOriented.Abstraction.Sprint;

public class Human
{
    public void SprintRight()
    {
        RaiseIfCannotSprint();
        UseSprintStamina();

        _posX += _speed * 2;
    }

    public void SprintLeft()
    {
        RaiseIfCannotSprint();
        UseSprintStamina();

        _posX -= _speed * 2;
    }

    public void SprintUp()
    {
        RaiseIfCannotSprint();
        UseSprintStamina();

        _posY += _speed * 2;
    }

    public void SprintDown()
    {
        RaiseIfCannotSprint();
        UseSprintStamina();

        _posY -= _speed * 2;
    }

    private void RaiseIfCannotSprint()
    {
        if (_stamina <= 0)
        {
            throw new Exception("not enough stamina to sprint");
        }
    }

    private void UseSprintStamina()
    {
        _stamina -= 1;
    }

    // don't touch below this line

    private int _posX;
    private int _posY;
    private int _speed;
    private int _stamina;

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

    public Human(int posX, int posY, int speed, int stamina)
    {
        _posX = posX;
        _posY = posY;
        _speed = speed;
        _stamina = stamina;
    }
}
