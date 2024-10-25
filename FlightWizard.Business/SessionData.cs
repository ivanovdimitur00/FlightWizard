namespace FlightWizard.Business;
public class SessionData
{
	private readonly Dictionary<string, object> _data = [];

	public object this[string key]
	{
		get
		{
			if (_data.TryGetValue(key, out object? value))
			{
				return value;
			}
			else
			{
				throw new KeyNotFoundException($"The key '{key}' does not exist in SessionData.");
			}
		}
		set => _data[key] = value;
	}

	public void Add(string key, object value)
	{
		_data[key] = value;
	}

	public T Get<T>(string key)
	{
		if (_data.TryGetValue(key, out object? value) && value is T data)
		{
			return data;
		}
		else
		{
			throw new InvalidCastException($"The value associated with key '{key}' is not of type {typeof(T)}.");
		}
	}

	public bool ContainsKey(string key)
	{
		return _data.ContainsKey(key);
	}

	public void Remove(string key)
	{
		_data.Remove(key);
	}
}
