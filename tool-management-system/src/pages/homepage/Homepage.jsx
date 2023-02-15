import React from 'react';
import { AuthContext } from '../../hooks/AuthContext';
import { useContext } from 'react';
import { Box } from '@mui/system';

const Homepage = () => {
  const { user } = useContext(AuthContext);
  if (user.role === 'Manager') {
    return (
      <Box
        sx={{
          display: 'flex',
          flexDirection: 'column',
          alignItems: 'center',
          justifyContent: 'flex',
          width: '100%',
          margin: 'auto',
          fontSize: '36px',
          fontFamily: 'monospace'
        }}
      >
        WELCOME BACK TO TOOL MANAGEMENT SYSTEM
      </Box>
    );
  }
};

export default Homepage;
