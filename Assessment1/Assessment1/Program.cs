static bool IsPassing(double grade)
{
    if (grade > 65)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static double AverageGrades(double grade1, double grade2, double grade3)
{
    double average = (grade1 + grade2 + grade3) / 3;
    return average;
}

static string OddOrEvenAndPassing(double grade)
{
    int intGrade = (int)grade;

    if (IsPassing(grade) && (intGrade % 2 == 1))
    {
        return "passing and odd";
    }
    else if ((intGrade % 2 == 1))
    {
        return "failing and odd";
    }
    else if (IsPassing(grade) && (intGrade % 2 == 0))
    {
        return "passing and even";
    }
    else if ((intGrade % 2 == 0))
    {
        return "failing and even";

    }
    else
    {
        return "";
    }
}

