
static void desglose()
{


    int CAN, C200, C100, C50, C20, C10, C5;
    float M25, M50, M100;
    CAN = C200 = C100 = C50 = C20 = C10 = C5 = 0;
    M25 = M50 = M100 = 0;
    string linea;

    Console.WriteLine("Ingrese una cantidad:");
    linea = Console.ReadLine();
    CAN = Convert.ToInt32(linea);
    
    if ((CAN >= 200))
    {
        C200 = (CAN / 200);
        CAN = CAN - (C200 * 200);
    }

    if ((CAN >= 100))
    {
        C100 = (CAN / 100);
        CAN = CAN - (C100 * 100);

    }
    if ((CAN >= 50))
    {
        C50 = (CAN / 50);
        CAN = CAN - (C50 * 50);

    }
    if ((CAN >= 20))
    {
        C20 = (CAN / 20);
        CAN = CAN - (C20 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (CAN / 10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (CAN / 5);
        CAN = CAN - (C5 * 5);
    }
    if ((M25 >= 0.25))
    {
        M25 = ((int)(CAN / 0.25));
        CAN = ((int)(CAN * 0.25));

    }
    if ((M50 >= 0.50))
    {
        M50 = ((int)(CAN / 0.50));
        CAN = ((int)(M50 * 0.50));

    }
    if ((M100 >= 1.00))
    {
        M100 = ((int)(CAN / 1.00));
        CAN = ((int)(M100 * 1.00)); 
        

    }
    Console.WriteLine($"---ESTOS SON TUS BILLETES---");
    Console.WriteLine($"BILLETES DE 200: {C200}");
    Console.WriteLine($"BILLETES DE 100: {C100}");
    Console.WriteLine($"BILLETES DE 50: {C50}");
    Console.WriteLine($"BILLETES DE 20: {C20}");
    Console.WriteLine($"BILLETES DE 10: {C10}");
    Console.WriteLine($"BILLETES DE 5: {C5}");
    Console.WriteLine($"BILLETES DE 1: {CAN}");

    Console.WriteLine($"---ESTAS SON TUS MONEDAS---");
    Console.WriteLine($"MONEDAS DE 25 CEN : {M25}");
    Console.WriteLine($"MONEDAS DE 50 CEN : {M50}");
    Console.WriteLine($"MONEDAS DE Q1: {M100}");


}

desglose();