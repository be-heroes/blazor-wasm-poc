let sum = 0;

function Calculate(value, sign = "+")
{
    console.log("Adding", value, sign)

    sum = eval(`${sum} ${sign} ${value}`);
}

function Sum() {
    console.log("Sum:" + sum)

    return sum;
}