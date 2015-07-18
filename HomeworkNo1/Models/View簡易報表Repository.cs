using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeworkNo1.Models
{   
	public  class View簡易報表Repository : EFRepository<View簡易報表>, IView簡易報表Repository
	{

	}

	public  interface IView簡易報表Repository : IRepository<View簡易報表>
	{

	}
}