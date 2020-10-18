using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle, Circle circle2)
        {
            bool collides = false;
            Vector2 circlePos = circle.Position;
            Vector2 circle2Pos = circle2.Position;

            float mag = Vector2.Magnitude(circlePos, circle2Pos);
            float radmag = circle.Radius + circle2.Radius;
            if (mag < radmag)
            {
                collides = true;
            }
            else if (mag > radmag)
            {
                collides = false;
            }
            return collides;
        }
        public bool CollidesWithLine(Circle circle, Line line)
        {
            /*
              Ik zie nu pas (nadat ik er heel erg lang over heb nagedacht en het werkend heb gekregen)
              dat dit niet werkt aangezien een Vector alle kanten op kan gaan, en dit werkt alleen maar als
              de vector van linksonder naar rechtsboven gaat. Het zou kunnen werken maar dan moet je honderdduizend
              if statements gaan schrijven om te checken wat de richting van de Vector is. En dat kan maar dan moet ik
              honderdduizend if statements gaan schrijven.
              
              Ik heb ervoor gekozen om zelf een mannier te vinden (ipv de info die je aangeboden had, ik heb het wel doorgelezen)
              omdat dat me een leuke mannier leek om te stoeien met de lesstof die we hebben gekregen, in combinatie met de
              wiskunde B die ik op de middelbare school heb gehad.
            */
            bool collides = false;
            float lLength = line.Length;

            Vector2 normalizeLineDir = Vector2.Normalized(line.Direction);
            Vector2 endPoint = new Vector2(normalizeLineDir.x * lLength, normalizeLineDir.y * lLength);
            Vector2 linePos = line.Position;
            Vector2 circlePos = circle.Position;
            float a = (endPoint.y - linePos.y) / (endPoint.x - linePos.x);
            float b = (a * linePos.x) - linePos.y;
            float collY = (a * circlePos.x) - circlePos.y;
            float collX = (collY - b) / a;
            float magLineCircle = Vector2.Magnitude(new Vector2(collX, collY), circlePos);
            float magLineCircleS = Vector2.Magnitude(linePos, circlePos);
            float magLineCircleE = Vector2.Magnitude(endPoint, circlePos);

            //Dus als ik het werkende zou moeten krijgen voor vectoren die alle kanten op gaan,
            //Dan zou ik hier een hele boel if statements moeten neerzetten om te checken wat de
            //richting van de vector is.
            //Bijv. if(endPos.x > linePos.x){ bool leftToright = true; }

            if (magLineCircle < circle.Radius)
            {
                if (magLineCircle < magLineCircleE && magLineCircle > magLineCircleS)
                {
                    return collides = true;
                }
                else
                {
                    return collides = false;
                }
            }
            else
            {
                return collides = false;
            }
        }
    }
}
