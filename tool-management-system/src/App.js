import './App.css';
import { Routes, Route } from 'react-router-dom';
import { homePath, usersPath, toolsPath, aircraftsPath } from './constants/routes';
import AircraftsPage from './pages/aircrafts/AircraftsPage';
import Homepage from './pages/homepage/Homepage';
import ToolsPage from './pages/tools/ToolsPage';
import UsersPage from './pages/users/UsersPage';

function App() {
  return (
    <Routes>
      <Route path={homePath} element={<Homepage />} />
      <Route path={usersPath} element={<UsersPage />}/>
      <Route path={toolsPath} element={<ToolsPage />}/>
      <Route path={aircraftsPath} element={<AircraftsPage />}/>
    </Routes>
  );
}

export default App;
