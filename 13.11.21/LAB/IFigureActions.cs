using System.Drawing;

namespace LAB
{
    interface IFigureActions
    {
        void Move(MovingType movingType, double value);
        void SetColor(Color color);
        void ChangeVisible();
    }
}