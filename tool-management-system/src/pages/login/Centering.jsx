import React from 'react';
import { Grid } from '@mui/material';

const Centering = (props) => {
  return (
    <Grid
      container
      direction='column'
      alignItems='center'
      justifyContent='center'
      sx={{ minHeight: '100vh' }}
    >
      <Grid item xs={1}>
        {props.children}
      </Grid>
    </Grid>
  );
};

export default Centering;
