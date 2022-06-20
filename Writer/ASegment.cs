namespace Writer
{
    public interface ASegment
    {
        float Length { get; }
        Point Center { get; }

        Point get_point(uint points, uint point, double angle)
        {
            if (angle >= Math.PI || angle < 0.0)
                throw new ArgumentOutOfRangeException(nameof(angle), "Angle must be in range from 0 to Pi");

            if (points < 2 || points > 5)
                throw new ArgumentOutOfRangeException(nameof(points), "Points must be in range from 2 to 5");

            if (point >= points)
                throw new ArgumentOutOfRangeException(nameof(point), "Point must be in range from 0 to points-1");

            var points1 = points - 1;

            var unaryLength = Length / (points1);

            float position = 0f;

            if (points % 2 == 1) // center point
            {
                var zeropos = points / 2;

                if (zeropos != point)
                {

                    uint i = zeropos;

                    if (zeropos < point) // positive subsegment
                        while (i++ < point)
                            position += unaryLength;

                    else // negative subsegment
                        while (i-- > point)
                            position -= unaryLength;
                }
            }
            else
            { // no center point

                if (point > points / 2 - 1)
                { // positive subsegment

                    uint i = points / 2;
                    while (i++ < point)
                        position += unaryLength;

                    position += unaryLength / 2;
                }
                else
                { // negative subsegment

                    uint i = points / 2 - 1;
                    while (i-- > point)
                        position -= unaryLength;

                    position -= unaryLength / 2;
                }
            }

            var angle_ = position < 0 ? angle + Math.PI : angle;
            var position_ = Math.Abs(position);

            var x = (float)(Math.Cos(angle_) * position_);
            var y = (float)(Math.Sin(angle_) * position_);

            return new Point(x, y);
        }
    }
}