string[] orderNumbers = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

        foreach (string orderNumber in orderNumbers)
        {
            if (orderNumber.StartsWith("B"))
            {
                Console.WriteLine($"Possible fraudulent order number: {orderNumber}");
            }
        }