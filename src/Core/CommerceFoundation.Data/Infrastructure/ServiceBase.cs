﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Foundation.Frameworks;
using VirtoCommerce.Foundation.Frameworks.Extensions;

namespace VirtoCommerce.Foundation.Data.Infrastructure
{
	public abstract class ServiceBase
	{
		protected virtual void CommitChanges(IRepository repository)
		{
			try
			{
				repository.UnitOfWork.Commit();
			}
			catch (Exception ex)
			{
				ex.ThrowFaultException();
			}
		}

		protected virtual ObservableChangeTracker GetChangeTracker(IRepository repository)
		{
			var retVal = new ObservableChangeTracker
			{
				RemoveAction = (x) =>
				{
					repository.Remove(x);
				},
				AddAction = (x) =>
				{
					repository.Add(x);
				}
			};

			return retVal;
		}
	}
}
