using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorAritmetica
{
    internal class Aritmetica : aritmeticaBaseVisitor<int>
    {
        public override int Visit(IParseTree tree)
        {
            return base.Visit(tree);
        }

        public override int VisitAritmetica([NotNull] aritmeticaParser.AritmeticaContext context)
        {
            return base.VisitAritmetica(context);
        }

        public override int VisitExpresion([NotNull] aritmeticaParser.ExpresionContext context)
        {
            Console.WriteLine(context.GetText());
            return base.VisitExpresion(context);
        }

        public override int VisitFactor([NotNull] aritmeticaParser.FactorContext context)
        {
            Console.WriteLine(context.NUM().GetText());
            return base.VisitFactor(context);
        }

        public override int VisitTermino([NotNull] aritmeticaParser.TerminoContext context)
        {
            return base.VisitTermino(context);
        }
    }
}
