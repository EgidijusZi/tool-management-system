import './App.css';
import { Routes, Route } from 'react-router-dom';
import {
  homePath,
  usersPath,
  toolsPath,
  aircraftsPath,
  toolboxesPath
} from './constants/routes';
import Homepage from './pages/homepage/Homepage';
import ToolsPage from './pages/tools/ToolsPage';
import UsersPage from './pages/users/UsersPage';
import Header from './components/header/Header';
import Sidebar from './components/sidebar/Sidebar';
import { toolboxColumns, aircraftColumns } from './components/table/PageColumns';
import TablePage from './pages/tablePage/TablePage';

function App() {
  return (
    <div className='app'>
      <Header />
      <main className='content'>
        <Sidebar />
        <Routes>
          <Route path={homePath} element={<Homepage />} />
          <Route path={usersPath} element={<UsersPage />} />
          <Route path={toolsPath} element={<ToolsPage />} />
          <Route path={aircraftsPath} element={<TablePage columns={aircraftColumns} apiBasePath={'Aircraft'} />} />
          <Route path={toolboxesPath} element={<TablePage columns={toolboxColumns} apiBasePath={'Toolbox'} />} />
        </Routes>
      </main>
    </div>
  );
}

export default App;
