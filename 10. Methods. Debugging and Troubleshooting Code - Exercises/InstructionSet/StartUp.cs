namespace InstructionSet
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string opCode = "";

            while (opCode != "END")
            {
                opCode = Console.ReadLine();

                string[] codeArgs = opCode.Split(' ');

                long result = 0;

                if (opCode == "END")
                {
                    continue;
                }

                switch (codeArgs[0])
                {
                    case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                    case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                    case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (operandOne * operandTwo);
                        break;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
