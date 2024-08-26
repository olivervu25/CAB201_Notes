class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public float Add(float a, float b)
    {
        return a + b;
    }
}

// Usage
MathOperations math = new MathOperations();
int sumInt = math.Add(5, 10);     // Calls the int version
float sumFloat = math.Add(5.5f, 10.5f); // Calls the float version
