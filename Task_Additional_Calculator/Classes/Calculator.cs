static class Calculator
{
    /// <summary>
    /// Gets Sum = augend + added, using extention parameter (this)
    /// </summary>
    /// <param name="augend"></param>
    /// <param name="added"></param>
    /// <returns>Double Sum</returns>
    public static double Add(this double augend, double added)
    {
        return augend + added;
    }

    /// <summary>
    /// Gets Difference = minued - subtrahend, using extention parameter (this)
    /// </summary>
    /// <param name="minued"></param>
    /// <param name="subtrahend"></param>
    /// <returns>Double Difference</returns>
    public static double Sub(this double minued, double subtrahend)
    {
        return minued - subtrahend;
    }

    /// <summary>
    /// Gets Product = multiplicand * multiplier, using extention parameter (this)
    /// </summary>
    /// <param name="multiplicand"></param>
    /// <param name="multiplier"></param>
    /// <returns>Double Product</returns>
    /// 
    public static double Mul(this double multiplicand, double multiplier)
    {
        return multiplicand * multiplier;
    }

    /// <summary>
    /// Gets Quotient = dividend / divider, using extention parameter (this)
    /// if divider <= 0 -> Error
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divider"></param>
    /// <returns>Double Quotient</returns>
    public static double Div(this double dividend, double divider)
    {
        if (divider > 0)
        {
            return dividend / divider;
        }

        else
        {
            Console.Write("B < = 0!");
            return 0;
        }
    }
}
