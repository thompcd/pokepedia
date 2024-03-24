﻿//namespace Pokepedia.Components
//{
//    public class deleteme
//    {
//    }
//}

//import React, { useState, useEffect } from 'react';
//import { getPokemon } from '../services/pokemon';
//import { useLocation } from 'react-router-dom';
//import StatLine from './StatLine';

//const Pokemon = () => {
//    const location = useLocation();

//    const [pokemon, setPokemon] = useState([]);

//    useEffect(() => {
//        getPokemon(location.pathname).then((data) => {
//            setPokemon(data);
//        });
//    }, [location.pathname]);

//    const { id, name } = pokemon;
//    const hiRes = true;

//    let s = location.pathname.split('/')
//  let num = +(s[s.length - 1])

//  const spriteBasePath = (number) => {
//      if (hiRes)
//      {
//          return `https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/${number}.svg`
//    }
//      else
//      {
//          return `https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${number}.png`
//    }
//  }

//  const nextPokemon = () => {
//      return "/pokemon/" + (num + 1)
//  }
//  const previousPokemon = () => {
//      return "/pokemon/" + (num - 1)
//  }

//  console.log(pokemon)
//  return (
//    < div
//      className ={`poke - card pokeCard--${
//            pokemon.types && pokemon.types[0].type['name']
//      }`}
//    >
//        < div className = 'poke-name panel screen' >
//            < span className = 'pokemon-name' >{ name} </ span >
//            < span className = 'poke-id' > no. { id}</ span >
//        </ div >
//      < div className = 'poke-details' >
//        < div className = 'poke-stats panel screen' >
//          < h3 > Base Stats </ h3 >
//          < div >
//            {
//        pokemon.stats &&
//              pokemon.stats.map((stat, index) => {
//              return (

//                < StatLine name ={ stat['stat']['name']}
//              value ={ stat['base_stat']} />
//                  );
//    })}
//</ div >
//        </ div >
//        < div className='poke-info abilities-panel panel screen'>
//            <h3>Abilities</h3>
//            <ul className='abilities'>
//                {pokemon.abilities &&
//                pokemon.abilities.map((ability, index) => {
//                    return (
//                        <li className='ability' key={index}>
//                        { ability['ability']['name']}
//                    </ li >
//                    );
//                })}
//            </ ul >
//        </ div >
//      </ div >

//      < div className = 'poke-img' >
//        < img
//          className = 'sprite'
//          src ={ spriteBasePath(id)}
//alt = 'pokemon-pic'
///>

//</ div >

//< div className = 'poke-type' >

//< ul className = 'types' >
//              {
//    pokemon.types &&
//              pokemon.types.map((type, index) => {
//              return (

//                  < li className ={`type ${ type['type']['name']}`}
//              key ={ index}>
//                      { type['type']['name']}
//                  </ li >
//                  );
//})}
//          </ ul >
//      </ div >
//      < div className = 'page-nav blue-buttons' >
//        < a className = 'button' href ={ previousPokemon()}> </ a >
//        < a className = 'button' href ={ nextPokemon()}> </ a >
//      </ div >
//    </ div >
//  );
//};