import React from 'react';
import { AuthContext } from '../../hooks/AuthContext';
import { useContext, useEffect } from 'react';
import { Box } from '@mui/system';
import EngineerHomepage from './EngineerHomepage';
import { endPoints } from '../../services/business/api';
import { useState } from 'react';
import { apiService } from '../../services/business/api';
import { Typography } from '@mui/material';

const Homepage = () => {
  const { user } = useContext(AuthContext);

  const [takenTools, setTakenTools] = useState([]);

  const toolApiService = apiService(endPoints.toolsTaken);

  const fetchData = async () => {
    const response = await toolApiService.fetchAll(user.token);
    setTakenTools(response.data);
    console.log(takenTools);
  };

  useEffect(() => {
    fetchData();
  }, []);

  if (user.role === 'Manager' || 'Storekeeper') {
    return (
      <Box
        sx={{
          display: 'flex',
          flexDirection: 'column',
          justifyContent: 'flex',
          width: '100%',
          mt: 2,
          
        }}
      >
        <Typography sx={{
          ml: 1,
          alignItems: 'left',
          fontSize: '36px',
          fontFamily: 'monospace',
        }}>Currently taken tools:</Typography>
        
      </Box>
    );
  } else if (user.role === 'Engineer') {
    return (<EngineerHomepage />)
  }
};

export default Homepage;
