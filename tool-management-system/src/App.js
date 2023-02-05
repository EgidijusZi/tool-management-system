import './App.css';
import { Routes, Route, useNavigate } from 'react-router-dom';
import {
  homePath,
  usersPath,
  toolsPath,
  aircraftsPath,
  toolboxesPath,
  loginPath
} from './constants/routes';
import Homepage from './pages/homepage/Homepage';
import Header from './components/header/Header';
import Sidebar from './components/sidebar/Sidebar';
import { toolboxColumns, aircraftColumns, toolColumns, userColumns } from './components/table/PageColumns';
import TablePage from './pages/tablePage/TablePage';
import { useContext, useEffect } from 'react';
import { AuthContext } from './hooks/AuthContext';
import LoginPage from './pages/login/LoginPage';

function App() {

  const { user } = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    if(!user) {
      navigate(loginPath);
    }
  }, [user])

  return (
    user ? (
      <div className='app'>
      <Header />
      <main className='content'>
        <Sidebar />
        <Routes>
          <Route path={homePath} element={<Homepage />} />
          <Route path={usersPath} element={<TablePage columns={userColumns} apiBasePath={'User'} />} />
          <Route path={toolsPath} element={<TablePage columns={toolColumns} apiBasePath={'Tool'}/>} />
          <Route path={aircraftsPath} element={<TablePage columns={aircraftColumns} apiBasePath={'Aircraft'} />} />
          <Route path={toolboxesPath} element={<TablePage columns={toolboxColumns} apiBasePath={'Toolbox'} />} />
          <Route path={loginPath} element={<LoginPage/>}/>
        </Routes>
      </main>
    </div>
    ) : (
      <Routes>
        <Route path={loginPath} element={<LoginPage />} />
      </Routes>
    )
  )
    
}

export default App;
