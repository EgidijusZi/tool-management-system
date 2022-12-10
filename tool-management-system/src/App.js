import './App.css';
import { Routes, Route } from 'react-router-dom';
import { homePath, usersPath, toolsPath, aircraftsPath } from './constants/routes';
import AircraftsPage from './pages/aircrafts/AircraftsPage';
import Homepage from './pages/homepage/Homepage';
import ToolsPage from './pages/tools/ToolsPage';
import UsersPage from './pages/users/UsersPage';
import Header from './components/header/Header';
import Sidebar from './components/sidebar/Sidebar';

function App() {
  return (
    <div className="app">
      <Header />
      <main className="content">
        <Sidebar />
        <Routes>
          <Route path={homePath} element={<Homepage />} />
          <Route path={usersPath} element={<UsersPage />} />
          <Route path={toolsPath} element={<ToolsPage />} />
          <Route path={aircraftsPath} element={<AircraftsPage />} />
        </Routes>
      </main>
    </div>
  );
}

export default App;
