using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    public partial class DoublyLinkedList<T> 
        : IContainer<T>, IStaticSequence<T>, IDynamicSequence<T>, ISearchableSequence<T>, IEnumerable<T>
    {
        private Node? _head, _tail;
        private int _length;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        public DoublyLinkedList(IEnumerable<T> items) 
            : this()
        {
            Build(items);
        }

        public void Build(IEnumerable<T> items)
        {
            Node? previousNode = null;

            foreach(T item in items)
            {
                Node newNode = new Node(item, previous: previousNode);
            
                _head ??= newNode;

                if (previousNode is not null)
                    previousNode.Next = newNode;

                previousNode = newNode;
                _length++;
            }

            _tail = previousNode;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        public T GetAt(int index)
        {
            Node node = GetNodeAt(index)
                ?? throw new IndexOutOfRangeException();

            return node.Item;
        }

        public void SetAt(int index, T newItem)
        {
            Node node = GetNodeAt(index)
                ?? throw new IndexOutOfRangeException();

            node.Item = newItem;
        }
        
        public void InsertAt(int index, T item)
        {
            /*
             * -> Ottiene il nodo corrente all'indice dato, se è fuori dai limiti lancia un'eccezione
             * 
             * -> Ottiene poi il nodo precedente a quello corrente, se presente, tramite il puntatore
             *
             * -> Crea il nuovo nodo, con come nodo precedente quello prima di quello corrente 
             *    e come nodo successivo quello corrente.
             *    
             * -> Se il nodo precedente non è null (quindi il nuovo nodo non è il primo della lista):
             *      - Allora fa puntare il suo nodo successivo a quello nuovo
             *      - Altrimenti non ci sono nodi precedenti quindi il nuovo nodo sarà puntato da head.
             */
            
            Node currentNode = GetNodeAt(index);
            Node? previousNode = currentNode.Prev;
        
            Node newNode = new Node(
                item, 
                previous: previousNode, 
                next: currentNode);

            if (previousNode is not null)
                previousNode.Next = newNode;
            else
                _head = newNode;

            currentNode.Prev = newNode;
            _length++;
        }

        public void DeleteAt(int index)
        {
            /*
             * -> Si ottiene il nodo ad eliminare dato l'indice
             * 
             * -> Si salvano i nodi precedente e successivo a quello da eliminare
             * 
             * -> Se il nodo precedente non è null (quindi non è il primo elemento della lista):
             *      - Allora il nodo precedente avrà come prossimo nodo il riferimento al nodo successivo
             *        a quello da eliminare
             *      - Altrimenti se è primo nella lista, head punta al nodo successivo a quello da eliminare
             *      
             * -> Stesso ragionamento per il nodo successivo a quello da eliminare...
             */

            Node nodeToDelete = GetNodeAt(index);
            Node? previousNode = nodeToDelete.Prev;
            Node? nextNode = nodeToDelete.Next;

            if (previousNode is not null)
                previousNode.Next = nextNode;
            else
                _head = nextNode;

            if (nextNode is not null)
                nextNode.Prev = previousNode;
            else
                _tail = previousNode;

            _length--;
        }

        public void InsertFirst(T item)
        {
            /*
             * -> Crea il nuovo nodo che sarà in prima posizione, che ha come nodo successivo
             *    lo stesso nodo puntato da head (se c'é già almeno un nodo)
             *
             * -> Se head punta ad un nodo esistente:
             *      - allora quel nodo avrà come nodo precedente il nodo 
             *      appena creato (che diventerà il nuovo head)
             *      - altrimenti se il nodo head è null, significa che la lista è vuota, quindi 
             *      anche head dovrà puntare al nuovo nodo (unico nella lista)
             */

            Node newFirstNode = new Node(item, next: _head);

            if (_head is not null)
                _head.Prev = newFirstNode;
            else
                _tail = newFirstNode;

            _head = newFirstNode;
            _length++;
        }

        public void DeleteFirst()
        {
            /*
             * -> Se la lista è vuota, lancia un'eccezione
             *
             * -> Head ora punta al nodo che si trovava nel suo puntatore al nodo successivo
             * 
             * -> Se ora head non è null (quindi c'é almeno un altro elemento 
             *    davanti a cui punta tail):
             *      - resetta a null il puntatore al nodo precedente, facendo si che venga perso il vecchio head
             *      - altrimenti se head è null, significa che la lista è vuota e quindi anche tail diventa null
             */
            
            if (IsEmpty())
                throw new InvalidOperationException("Cannot delete from empty list.");

            _head = _head!.Next;

            if (_head is not null)
                _head.Prev = null;
            else
                _tail = null;
            
            _length--;
        }

        public void InsertLast(T item)
        {
            /*
             * -> Si crea il nuovo nodo che avrà come nodo precedente l'ultimo elemento corrente
             * 
             * -> Se c'é già un ultimo elemento allora quest'ultimo avrà come nodo 
             *    successivo il nuovo nodo
             * 
             * -> Se non c'é un ultimo elemento (quindi lista vuota) il nuovo elemento sarà puntato anche 
             *    da head
             */
            
            Node newLastNode = new Node(item, previous: _tail);

            if (_tail is not null)
                _tail.Next = newLastNode;
            else
                _head = newLastNode;

            _tail = newLastNode;
            _length++;
        }

        public void DeleteLast()
        {
            /*
             * -> Se la lista è già vuota, si lancia un'eccezzione (non c'é nulla da rimuovere)
             * 
             * -> Si prende il nodo precedente all'ultimo
             * 
             * -> Se non è null (quindi il nodo puntato da tail non è 
             * lo stesso puntato da head, che sarebbe l'unico elemento):
             *      - Allora next diventa null (perché diventa l'ultimo elemento)
             *      - Altrimenti anche head diventa null, perché la lista ora è vuota
             */

            if (IsEmpty())
                throw new InvalidOperationException("Cannot delete from empty list.");

            _tail = _tail!.Prev;

            if (_tail is not null)
                _tail.Next = null;
            else
                _head = null;

            _length--;
        }

        public bool IsEmpty()
        {
            return _length == 0;
        }

        public int GetLength()
        {
            return _length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? currentNode = _head;
            
            while(currentNode is not null)
            {
                yield return currentNode.Item;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> Reverse()
        {
            Node? currentNode = _tail;

            while (currentNode is not null)
            {
                yield return currentNode.Item;
                currentNode = currentNode.Prev;
            }
        }

        private Node GetNodeAt(int index)
        {
            if (index < 0 || index >= _length)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            Node? currentNode = null;

            if (index < _length / 2)
            {
                currentNode = _head;

                for (int i = 0; i < index; i++)
                    currentNode = currentNode!.Next;
            }
            else
            {
                currentNode = _tail;

                for (int i = _length - 1; i > index; i--)
                    currentNode = currentNode!.Prev;
            }

            return currentNode!;
        }

        public int FindIndex(T item)
        {
            return FindIndex(currentItem =>
            {
                return EqualityComparer<T>.Default.Equals(currentItem, item);
            });
        }

        public int FindIndex(Predicate<T> predicate)
        {
            int index = 0;
            foreach (T currentItem in this)
            {
                if (predicate(currentItem))
                    return index;

                index++;
            }

            return -1;
        }

        public bool Contains(T item)
        {
            return (FindIndex(item) != -1);
        }

        public T? Find(Predicate<T> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
