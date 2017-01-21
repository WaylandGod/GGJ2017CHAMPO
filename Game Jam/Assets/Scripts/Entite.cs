﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entite : MonoBehaviour {

	public Coord PositionActuelle { get; set; }

	private Queue<Coord> _positions;
	private Queue<Coord> positions {
		get
		{
			if (_positions != null)
				return _positions;
			else
			{
				_positions = new Queue<Coord> (Constantes.MEMOIRE_ENTITEES);
				_positions.Enqueue (PositionActuelle);
			}
		}
	}

	public virtual void Move() {}

	public void UpdateEntite ()
	{
		Move ();
		if ( !(positions.Count < Constantes.MEMOIRE_ENTITEES ) )
			positions.Dequeue ();
		
		positions.Enqueue (PositionActuelle);
	}

	
	public bool VisibilityFrom ( Coord fromPos, out Dictionary<Vector2, float> intensities )
	{
		foreach (Coord pos in positions) {
			if 
		}

		intensities = new Dictionary<Vector2, float> ();
		return false;	
	}

	

	public bool VisibilityFrom ( Vector2 fromPos, out Vector2 maxIntensitePos )
	{
		maxIntensitePos = Vector2.zero;
		return false;	
	}
	

}
