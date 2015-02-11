﻿using System;
using System.Linq;
using VirtoCommerce.Foundation.Frameworks;
using VirtoCommerce.Foundation.Frameworks.Extensions;
using VirtoCommerce.ManagementClient.Core.Controls;
using VirtoCommerce.ManagementClient.Core.Infrastructure;
using linq = System.Linq.Expressions;

namespace VirtoCommerce.ManagementClient.Catalog.Model.TypedExpressions.Conditions
{
    /// <summary>
    /// AndOrBlock for Expression Builder. Can't move to VirtoCommerce.ManagementClient.Core as it references VirtoCommerce.Foundation
    /// </summary>
    [Serializable]
	public class ConditionAndOrBlock : TypedExpressionElementBase, IExpressionAdaptor
    {
		public ConditionAndOrBlock(string namePrefix, IExpressionViewModel expressionViewModel, string nameSuffix, bool isAddBlock)
			: base(namePrefix + " ... " + nameSuffix, expressionViewModel)
        {
			AndOr = new AndOr();
			if (isAddBlock)
				AndOr = WithElement(AndOr) as AndOr;
            if (!string.IsNullOrEmpty(namePrefix)) WithLabel(namePrefix);
            AllAny = WithElement(new AllAny()) as AllAny;
            if (!string.IsNullOrEmpty(nameSuffix)) WithLabel(nameSuffix);
        }

		public AndOr AndOr { get; set; }
        public AllAny AllAny { get; set; }

		public linq.Expression<Func<IEvaluationContext, bool>> GetExpression()
        {
			linq.Expression<Func<IEvaluationContext, bool>> retVal = AllAny.IsAll ? PredicateBuilder.True<IEvaluationContext>() : PredicateBuilder.False<IEvaluationContext>();
            foreach (var adaptor in this.Children.OfType<IExpressionAdaptor>())
            {
                var expression = adaptor.GetExpression();
                if (!AllAny.IsAll)
                {
                    retVal = retVal.Or(expression);
                }
                else
                {
                    retVal = retVal.And(expression);
                }
            }
            return retVal;
        }
    }
}
