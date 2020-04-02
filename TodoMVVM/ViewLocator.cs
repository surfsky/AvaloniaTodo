using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Todo.ViewModels;

namespace Todo
{
    public class ViewLocator : IDataTemplate
    {
        public bool SupportsRecycling => false;


        /// <summary>�����������ͣ��� AbcViewModel��������Ӧ����ͼ��AbcView��</summary>
        /// <param name="data">ViewModel ʵ��</param>
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