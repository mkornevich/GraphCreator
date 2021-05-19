using GraphCreator.Helper;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Algorithm
{
    public class IO
    {
        private IOManager io;

        private Project project;
        public IO(IOManager iOManager, Project project)
        {
            io = iOManager;
            this.project = project;
        }

        public string Read()
        {
            return io.Read();
        }

        public string ReadLn()
        {
            return io.Read("\r\n");
        }

        public void Write(object obj)
        {
            io.Write(obj.ToString());
        }

        public void WriteLn(object obj = null)
        {
            if (obj == null)
            {
                WriteLn("");
                return;
            }
            Write(obj.ToString() + "\r\n");
        }

        public T SmartRead<T>(string caption = null)
        {
            if (caption != null)
                WriteLn(caption);

            var readType = typeof(T);

            var allowTypes = new Type[] {
                typeof(string),
                typeof(int),
                typeof(double),
                typeof(float),
            };

            if (!allowTypes.Contains(readType))
                throw new Exception(string.Format("Ввод типа {0} не предусмотрен.", readType.Name));

            object readResult = null;

            bool hasTypeError = false;
            do
            {
                hasTypeError = false;
                Write("> ");
                var inputStr = Read();

                if (readType == typeof(string))
                    return (T)(object)inputStr;

                var method = readType.GetMethod("Parse", new Type[] { typeof(string) });
                try
                {
                    readResult = method.Invoke(null, new object[] { inputStr });
                }
                catch (Exception)
                {
                    hasTypeError = true;
                    WriteLn(" -> неверно, попробуйте еще раз");
                }
            } while (hasTypeError);

            return (T)readResult;
        }

        public T SmartReadLn<T>(string caption = null)
        {
            T obj = SmartRead<T>(caption);
            WriteLn();
            return obj;
        }

        public List<Vertex> ReadLnExistVertexes(string caption = null)
        {
            if (caption != null)
                WriteLn(caption);
            var vertexes = new List<Vertex>();
            int count = SmartReadLn<int>("Кол-во:");
            for (int i = 0; i < count; i++)
                vertexes.Add(ReadLnExistVerex());
            return vertexes;
        }

        public Vertex ReadLnExistVerex(string caption = null)
        {
            if (caption != null)
                WriteLn(caption);

            Vertex findVertex;
            bool hasError = false;

            do
            {
                hasError = false;
                string strVertex = SmartRead<string>();
                findVertex = project.Vertexes.Find(vertex => VertexHelper.IsStringEqualsVertex(strVertex, vertex));
                if (findVertex == null)
                {
                    hasError = true;
                    WriteLn(" // такой вершины нету, попробуйте снова");
                }
            } while (hasError);

            WriteLn();

            return findVertex;
        }

        public List<Edge> ReadLnExistEdges(string caption = null)
        {
            if (caption != null)
                WriteLn(caption);
            var edges = new List<Edge>();
            int count = SmartReadLn<int>("Кол-во:");
            for (int i = 0; i < count; i++)
                edges.Add(ReadLnExistEdge());
            return edges;
        }

        public Edge ReadLnExistEdge(string caption = null)
        {
            if (caption != null)
                WriteLn(caption);

            Edge findEdge;
            bool hasError = false;

            do
            {
                hasError = false;
                string strEdge = SmartRead<string>();
                findEdge = project.Edges.Find(edge => EdgeHelper.IsStringEqualsEdge(strEdge, edge));
                if (findEdge == null)
                {
                    hasError = true;
                    WriteLn(" // такого ребра нету, попробуйте снова");
                }
            } while (hasError);

            WriteLn();

            return findEdge;
        }

    }
}
