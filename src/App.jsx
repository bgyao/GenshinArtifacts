import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Sidebar from './components/Sidebar'
import TestComponent from './components/TestComponent'

function App() {
  const [count, setCount] = useState(0)
  const [currentPage, setCurrentPage] = useState("Home");

  const renderPage = () => {
    switch (currentPage) {
      case "Home":
        return (
          <>
            <div>
              <a href="https://vite.dev" target="_blank">
                <img src={viteLogo} className="logo" alt="Vite logo" />
              </a>
              <a href="https://react.dev" target="_blank">
                <img src={reactLogo} className="logo react" alt="React logo" />
              </a>
            </div>
            <h1>Vite + React</h1>
            <div className="card">
              <button onClick={() => setCount((count) => count + 1)}>
                count is {count}
              </button>
              <p>
                Edit <code>src/App.jsx</code> and save to test HMR
              </p>
            </div>
            <p className="read-the-docs">
              Click on the Vite and React logos to learn more
            </p>
          </>
        );
      case "Test":
        return (
          <>
            <div className="min-h-screen bg-gray-50 flex items-center justify-center">
              <TestComponent />
            </div>
          </>
        );
      default:
        return <div>Page not found</div>;
    }
  };

  return (
    <>
      <div className="flex h-screen">
        <Sidebar currentPage={currentPage} setCurrentPage={setCurrentPage} />
        <div className="flex-1 p-6 overflow-auto">
          {renderPage()}
        </div>
      </div>
    </>
  );
}

export default App
