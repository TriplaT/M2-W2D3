// Carrello e sconti particolari

/*
Oggi il tuo compito è creare la logica per un sito di e-commerce che deve supportare sconti extra per utenti speciali.
A partire da una lista di prezzi, un utente e un costo di spedizione l'algoritmo deve determinare il costo totale del carrello.
ATTENZIONE! Gli argomenti di questa settimana sono cruciali per lo svolgimento di un lavoro di un developer (il 90% del dati che maneggerai saranno array di oggetti!!) quindi 
assicurati di COMPRENDERE la logica. Se ti trovi in difficolta', scrivi ad un membro del teaching staff! :) 

Se l'utente ha la proprietà "isAmbassador" con valore true, il carrello deve venire scontato del 30%, PRIMA di calcolare la spedizione (anche gli utenti speciali pagano le spedizioni).
Se l'utente ha la proprietà "isAmbassador" con valore false, il carrello NON deve venire scontato.
In entrambi i casi, la spedizione è gratuita per ogni carrello con costo superiore a 100. Altrimenti, aggiungi il valore fornito per coprire il costo della spedizione.

In basso troverai degli esempi di utenti, una lista prezzi e un costo fisso di spedizione.
Crea un array di utenti (usando .push) e stampa, per ogni utente (quindi con un loop) la frase "NOMEUTENTE COGNOMEUTENTE e' / non e' un ambassador" basandoti sui dati contenuti nell'oggetto. 
ES. L'utente Marco Rossi e' un ambassador, quindi la frase dovrebbe essere "Marco Rossi e' un ambassador"
Infine, crea un SECONDO array in cui inserirai SOLO gli ambassador.
*/

const marco = {
  name: "Marco",
  lastName: "Rossi",
  isAmbassador: true,
}

const paul = {
  name: "Paul",
  lastName: "Flynn",
  isAmbassador: false,
}

const amy = {
  name: "Amy",
  lastName: "Reed",
  isAmbassador: false,
}

const prices = [34, 5, 2]
const shippingCost = 50
let utenteCheEffettuaLAcquisto = amy //cambia il valore qui per provare se il tuo algoritmo funziona!

/**
 * Array contenente tutti gli utenti
 */
const utenti = [marco, paul, amy]

/**
 * Funzione per stampare lo stato di ambassador di ogni utente
 * @param {Array} utentiArray - Array di utenti
 */
function stampaStatoAmbassador(utentiArray) {
  utentiArray.forEach(({ name, lastName, isAmbassador }) => {
    const stato = isAmbassador ? "è un ambassador" : "non è un ambassador"
    console.log(`${name} ${lastName} ${stato}`)
  })
}

/**
 * Funzione per filtrare solo gli ambassador
 * @param {Array} utentiArray - Array di utenti
 * @returns {Array} - Array contenente solo ambassador
 */
function filtraAmbassador(utentiArray) {
  return utentiArray.filter(({ isAmbassador }) => isAmbassador)
}

/**
 * Funzione per calcolare il totale del carrello con sconti e spedizione
 * @param {Array} prezzi - Array di prezzi
 * @param {Object} utente - Utente che effettua l'acquisto
 * @param {number} costoSpedizione - Costo fisso della spedizione
 * @returns {number} - Totale carrello
 */
function calcolaTotaleCarrello(prezzi, utente, costoSpedizione) {
  const totaleProdotti = prezzi.reduce((acc, prezzo) => acc + prezzo, 0)
  const sconto = utente.isAmbassador ? 0.3 : 0
  let totaleScontato = totaleProdotti * (1 - sconto)
  if (totaleScontato <= 100) {
    totaleScontato += costoSpedizione
  }
  return totaleScontato
}

// Uso delle funzioni
stampaStatoAmbassador(utenti)
const ambassador = filtraAmbassador(utenti)
const totaleCarrello = calcolaTotaleCarrello(prices, utenteCheEffettuaLAcquisto, shippingCost)

console.log("Totale carrello:", totaleCarrello)
