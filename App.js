import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import dane from './assets/dane.json';
import { useEffect, useState } from 'react';
import { Button, Image } from 'react-bootstrap';

function App() {
  const [bloki, setBloki] = useState([])
  const [pokazKwiaty, setPokazKwiaty] = useState(true)
  const [pokazZwierzeta, setPokazZwierzeta] = useState(true)
  const [pokazSamochody, setPokazSamochody] = useState(true)

  useEffect(() => {
    try {
      setBloki(dane.dane)
    } catch (error) {
      console.log(error)
    }
  }, [])

  function ZmienioneBloki() {
    bloki.filter((blok) => {
      if (blok.category == 1 && !pokazKwiaty) return false
      if (blok.category == 2 && !pokazZwierzeta) return false
      if (blok.category == 3 && !pokazSamochody) return false
    })
  }

  function PrzyciskPobierz(index) {
    
  }

  return (
    <div>
      <h1>Kategorie zdjęć</h1>
      <div style={{display: "flex", flexDirection: "row"}}>
        <div class="form-check form-switch">
          <input class="form-check-input" type="checkbox" id="przyciskKwiaty" checked={pokazKwiaty} onChange={(e) => setPokazKwiaty(e.target.checked)}/>
          <label class="form-check-label" for="przyciskKwiaty">Kwiaty</label>
        </div>
        
        <div class="form-check form-switch">
          <input class="form-check-input" type="checkbox" id="przyciskZwierzeta" checked={pokazZwierzeta} onChange={(e) => setPokazZwierzeta(e.target.checked)}/>
          <label class="form-check-label" for="przyciskZwierzeta">Zwierzęta</label>
        </div>
        
        <div class="form-check form-switch">
          <input class="form-check-input" type="checkbox" id="przyciskSamochody" checked={pokazSamochody} onChange={(e) => setPokazSamochody(e.target.checked)}/>
          <label class="form-check-label" for="przyciskSamochody">Samochody</label>
        </div>
      </div>

      <div style={{display: 'flex', flexDirection: 'row', flexWrap: 'wrap'}}>
        {bloki.length > 0 ? bloki.map((blok, index) => (
          <div style={{margin: 5}} key={index}>
            <Image src={`./assets/${blok.filename}`}/>
            <h4 id={index}>Pobrań: {blok.downloads}</h4>
            <Button variant='success' onClick={PrzyciskPobierz(index)}>Pobierz</Button>
          </div>
        )) : null}
      </div>
    </div>
  );
}

export default App;
