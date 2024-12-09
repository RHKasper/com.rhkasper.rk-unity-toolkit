using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RKUnityToolkit.UIElements
{
    public class GenericListDisplay : MonoBehaviour
    {
        [SerializeField] private RectTransform listObjectsParent; 
        
        private Dictionary<object, ListItemControllerBase> _activeListItems = new();
        private Dictionary<ListItemControllerBase, Stack<ListItemControllerBase>> _pooledListItems = new();
        
        public void DisplayList<TData>(List<TData> listToDisplay, ListItemController<TData> listItemPrefab)
        {
            HashSet<TData> hashSetToDisplay = listToDisplay.ToHashSet();

            foreach (object key in _activeListItems.Keys.ToList())
            {
                if(!(key is TData data && hashSetToDisplay.Contains(data)))
                {
                    Destroy(_activeListItems[key].gameObject);
                    _activeListItems.Remove(key);
                }
            }
                
            foreach (var data in listToDisplay)
            {
                if (!_activeListItems.ContainsKey(data))
                {
                    var instance = GetOrInstantiateListItemController<TData>(listItemPrefab);
                    instance.SetData(data);
                    instance.transform.SetAsLastSibling();
                    _activeListItems.Add(data, instance);
                }
            }
        }

        private ListItemController<TData> GetOrInstantiateListItemController<TData>(ListItemControllerBase listItemPrefab)
        {
            ListItemControllerBase instance;

            if (_pooledListItems.ContainsKey(listItemPrefab) && _pooledListItems[listItemPrefab].Any())
            {
                instance = _pooledListItems[listItemPrefab].Pop();
                instance.gameObject.SetActive(true);
            }
            else
            {
                instance = Instantiate(listItemPrefab, listObjectsParent);
            }

            return instance as ListItemController<TData>;
        }

        private void PoolListItem<TData>(ListItemController<TData> prefab, ListItemController<TData> instance)
        {
            instance.gameObject.SetActive(false);
            if (!_pooledListItems.ContainsKey(prefab))
            {
                _pooledListItems.Add(prefab, new Stack<ListItemControllerBase>());    
            }
            _pooledListItems[prefab].Push(instance);
        }

        public abstract class ListItemController<TData> : ListItemControllerBase
        {
            public TData Data { get; private set; }
            
            public void SetData(TData data)
            {
                Data = data;
                OnDataSet(data);
            }

            protected abstract void OnDataSet(TData data);
        }

        public class ListItemControllerBase : MonoBehaviour
        {
            
        }
    }
}
