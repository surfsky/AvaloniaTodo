using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Todo.ViewModels;

namespace Todo
{
    public class ViewLocator : IDataTemplate
    {
        public bool SupportsRecycling => false;


        /// <summary>根据数据类型（如 AbcViewModel）创建对应的视图（AbcView）</summary>
        /// <param name="data">ViewModel 实例</param>
        /// <returns></returns>
        public IControl Build(object data)
        {
            var name = data.GetType().FullName.Replace("ViewModel", "View");
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type);
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}