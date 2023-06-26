
namespace Interpreter
{
    interface Expression
    {
        int Interpret();
    }

    class NumberExpression : Expression
    {
        int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return number;
        }
    }

    class AdditionExpression : Expression
    {
        Expression leftExpression;
        Expression rightExpression;

        public AdditionExpression(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }

    class SubtractionExpression : Expression
    {
        Expression leftExpression;
        Expression rightExpression;

        public SubtractionExpression(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }

    class Interpreter
    {
        public static void Execute()
        {
            // (8-3)+(2+6)
            Expression expr = new AdditionExpression(
                new SubtractionExpression(
                    new NumberExpression(8),
                    new NumberExpression(3)
                ),
                new AdditionExpression(
                    new NumberExpression(2),
                    new NumberExpression(6)
                )
            );

            Console.WriteLine(expr.Interpret());
        }
    }
}